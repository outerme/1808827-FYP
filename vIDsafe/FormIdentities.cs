﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vIDsafe
{
    public partial class FormIdentities : Form
    {
        public FormIdentities()
        {
            InitializeComponent();

            LoadFormComponents();
        }

        private void LoadFormComponents()
        {
            GetIdentities();
        }

        private void chartCredentials_PrePaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {
            if (cmbIdentity.SelectedIndex >= 0)
            {
                if (e.ChartElement is System.Windows.Forms.DataVisualization.Charting.ChartArea)
                {
                    var ta = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation
                    {
                        Text = Convert.ToString(FormvIDsafe.Main.User.Vault.GetIdentity(cmbIdentity.SelectedIndex).GetCredentialCount()),
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

        private void btnNewIdentity_Click(object sender, EventArgs e)
        {
            NewIdentity();
        }

        private void NewIdentity()
        {
            string defaultIdentityName = "New identity";

            FormvIDsafe.Main.User.Vault.NewIdentity(defaultIdentityName);

            int lastIndex = cmbIdentity.Items.Add(defaultIdentityName);
            cmbIdentity.SelectedIndex = lastIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveIdentity();
        }

        private void SaveIdentity()
        {
            string identityName = txtIdentityName.Text;
            string identityEmail = txtIdentityEmail.Text;
            string identityUsage = txtIdentityUsage.Text;

            int selectedIdentityIndex = cmbIdentity.SelectedIndex;

            FormvIDsafe.Main.User.Vault.GetIdentity(selectedIdentityIndex).SetDetails(identityName, identityEmail, identityUsage);

            cmbIdentity.Items[selectedIdentityIndex] = identityName;
        }

        private void btnDeleteDiscard_Click(object sender, EventArgs e)
        {
            DeleteIdentity();
        }

        private void cmbIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIdentityDetails();
        }

        private void GetIdentities()
        {
            ResetDetails();
            cmbIdentity.Items.Clear();

            foreach (Identity identity in FormvIDsafe.Main.User.Vault.Identities)
            {
                cmbIdentity.Items.Add(identity.Name);
            }
        }

        private void GetIdentityDetails()
        {
            ResetDetails();
            int selectedIdentityIndex = cmbIdentity.SelectedIndex;

            if (selectedIdentityIndex >= 0)
            {
                Identity currentIdentity = FormvIDsafe.Main.User.Vault.GetIdentity(selectedIdentityIndex);

                txtIdentityName.Text = currentIdentity.Name;
                txtIdentityEmail.Text = currentIdentity.Email;
                txtIdentityUsage.Text = currentIdentity.Usage;

                chartCredentials.Series["Credentials"].Points[0].SetValueXY("Safe", currentIdentity.SafeCredentials);
                chartCredentials.Series["Credentials"].Points[1].SetValueXY("Weak", currentIdentity.WeakCredentials);
                chartCredentials.Series["Credentials"].Points[2].SetValueXY("Conflicts", currentIdentity.ConflictCredentials);
                chartCredentials.Series["Credentials"].Points[3].SetValueXY("Compromised", currentIdentity.CompromisedCredentials);
                chartCredentials.Series["Credentials"].IsValueShownAsLabel = true;
            }  
        }

        private void DeleteIdentity()
        {
            int selectedIdentityIndex = cmbIdentity.SelectedIndex;

            if (selectedIdentityIndex >= 0)
            {
                FormvIDsafe.Main.User.Vault.DeleteIdentity(selectedIdentityIndex);

                cmbIdentity.Items.RemoveAt(selectedIdentityIndex);

                GetIdentityDetails(); //SelectedIndex doesn't work with -1 for comboboxes for some reason?
            }
        }

        private void ResetDetails()
        {
            ClearInputs();

            int selectedIdentityIndex = cmbIdentity.SelectedIndex;

            if (selectedIdentityIndex >= 0)
            {
                txtIdentityName.Enabled = true;
                txtIdentityEmail.Enabled = true;
                txtIdentityUsage.Enabled = true;

                btnSave.Enabled = true;
                btnDeleteDiscard.Enabled = true;

                chartPublicInformation.Visible = true;
                chartCredentials.Visible = true;
            }
            else
            {
                txtIdentityName.Enabled = false;
                txtIdentityEmail.Enabled = false;
                txtIdentityUsage.Enabled = false;

                btnSave.Enabled = false;
                btnDeleteDiscard.Enabled = false;

                chartPublicInformation.Visible = false;
                chartCredentials.Visible = false;
            }
        }

        private void ClearInputs()
        {
            txtIdentityName.Clear();
            txtIdentityEmail.Clear();
            txtIdentityUsage.Clear();
            cmbIdentity.Text = "";
        }
    }
}
