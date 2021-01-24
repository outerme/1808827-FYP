﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vIDsafe
{
    public partial class FormOverview : Form
    {
        public FormOverview()
        {
            InitializeComponent();

            LoadFormComponents();
        }

        private void LoadFormComponents()
        {
            AddIdentityColumns();

            RecalculateHealthScore();
        }

        private void RecalculateHealthScore()
        {
            FormvIDsafe.Main.User.Vault.CalculateOverallHealthScore();
            DisplayHealthScores();
            DisplayCredentialInformation();
        }

        private void AddIdentityColumns()
        {
            tlpIdentities.ColumnStyles.Clear();
            for (int i = 0; i < FormvIDsafe.Main.User.Vault.Identities.Count; i++)
            {
                tlpIdentities.ColumnCount += 1;
                tlpIdentities.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }
        }

        private void DisplayHealthScores()
        {
            tlpIdentities.Controls.Clear();

            for (int i = 0; i < FormvIDsafe.Main.User.Vault.Identities.Count; i++)
            {
                Identity identity = FormvIDsafe.Main.User.Vault.Identities[i];

                Panel identityPanel = CreatePanel(CalculateHealthColor(identity.HealthScore));

                identityPanel.Controls.Add(CreateLabel(identity.Name));
                identityPanel.Controls.Add(CreateLabel(identity.HealthScore.ToString() + "%"));

                tlpIdentities.Controls.Add(identityPanel, i, 0);
            }

            foreach (ColumnStyle style in tlpIdentities.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 50F;
            }

            int totalHealthScore = FormvIDsafe.Main.User.Vault.OverallHealthScore;

            FormHome.SetHealthScore(totalHealthScore, CalculateHealthColor(totalHealthScore));
        }

        private Panel CreatePanel(Color backColor)
        {
            int panelPadding = 12;

            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(panelPadding),
                BackColor = backColor
            };

            return panel;
        }

        private Label CreateLabel(string text)
        {
            ContentAlignment textAlign = ContentAlignment.MiddleCenter;
            Font labelFont = new Font("Segoe UI", 9.75f);
            Color labelColor = Color.FromArgb(64, 64, 64);
            DockStyle dock = DockStyle.Bottom;

            Label label = new Label
            {
                AutoSize = false,
                Text = text,
                TextAlign = textAlign,
                Dock = dock,
                Font = labelFont,
                ForeColor = labelColor
            };

            return label;
        }

        private Color CalculateHealthColor(int healthScore)
        {
            int maxGoodScore = 100;
            int maxMediumScore = 75;
            int maxBadScore = 50;

            double colourAmplifier = 50;

            Color scoreColor = new Color();

            if (healthScore < maxBadScore)
            {
                scoreColor = Color.DarkSalmon;
            }
            else if (healthScore < maxMediumScore)
            {
                scoreColor = Color.Khaki;
            }
            else if (healthScore <= maxGoodScore)
            {
                scoreColor = Color.LimeGreen;
            }

            double colorMultiplier = (healthScore / (100 / colourAmplifier)) / 100;

            scoreColor = ChangeColorBrightness(scoreColor, (float)colorMultiplier);

            //Console.WriteLine(color);

            return scoreColor;
        }

        //https://gist.github.com/zihotki/09fc41d52981fb6f93a81ebf20b35cd5
        public static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = color.R;
            float green = color.G;
            float blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        private void DisplayCredentialInformation()
        {
            int safeCount = FormvIDsafe.Main.User.Vault.TotalSafeCredentials;
            int weakCount = FormvIDsafe.Main.User.Vault.TotalWeakCredentials;
            int conflictCount = FormvIDsafe.Main.User.Vault.TotalConflictCredentials;
            int compromisedCount = FormvIDsafe.Main.User.Vault.TotalCompromisedCredentials;

            chartCredentials.Series["Credentials"].Points[0].SetValueXY("Safe", safeCount);
            chartCredentials.Series["Credentials"].Points[1].SetValueXY("Weak", weakCount);
            chartCredentials.Series["Credentials"].Points[2].SetValueXY("Conflicts", conflictCount);
            chartCredentials.Series["Credentials"].Points[3].SetValueXY("Compromised", compromisedCount);

            chartCredentials.Series["Credentials"].IsValueShownAsLabel = true;
        }

        private void chartCredentials_PrePaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {
            DisplayCredentialCount(e);
        }

        private void DisplayCredentialCount(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {
            if (e.ChartElement is System.Windows.Forms.DataVisualization.Charting.ChartArea)
            {
                //Todo: cleanup, maybe separate method called createtextannotation? or maybe use label
                var ta = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation
                {
                    Text = Convert.ToString(FormvIDsafe.Main.User.Vault.TotalCredentialCount),
                    Width = e.Position.Width,
                    Height = e.Position.Height,
                    X = e.Position.X - (e.Position.Width / 100),
                    Y = e.Position.Y + (e.Position.Height / 100),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.Gainsboro
                };
                //ta.Alignment = ContentAlignment.MiddleCenter;

                chartCredentials.Annotations.Clear();
                chartCredentials.Annotations.Add(ta);
            }
        }
    }
}
