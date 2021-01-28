﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Linq;

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
            DisplayCredentialCount(e);
        }

        private void DisplayCredentialCount(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {
            string selectedEmail = cmbIdentity.SelectedItem.ToString();

            if (selectedEmail.Length > 0)
            {
                Identity identity = FormvIDsafe.Main.User.Vault.Identities[selectedEmail];

                if (e.ChartElement is System.Windows.Forms.DataVisualization.Charting.ChartArea)
                {
                    //Todo: cleanup, maybe separate method called createtextannotation? or maybe use label
                    var ta = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation
                    {
                        Text = Convert.ToString(identity.Credentials.Count),
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
            string email = FormvIDsafe.Main.User.Vault.NewIdentity();

            int lastIndex = cmbIdentity.Items.Add(email);
            cmbIdentity.SelectedIndex = lastIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetIdentityDetails(cmbIdentity.SelectedIndex, cmbIdentity.SelectedItem.ToString(), txtIdentityName.Text, txtIdentityEmail.Text, txtIdentityUsage.Text);
        }

        //Todo: cleanup parameter names everywhere (consistency)
        private bool IsValid(string name, string email)
        {
            if (email.Length > 0 && name.Length > 0)
            {
                Dictionary<string, Identity> identities = FormvIDsafe.Main.User.Vault.Identities;

                if (identities.ContainsKey(email))
                {
                    Console.WriteLine("Email already exists");
                    return false;
                }
                else
                {
                    try
                    {
                        MailAddress m = new MailAddress(email);

                        return true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e);
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter all details");
                return false;
            }
        }

        private void SetIdentityDetails(int selectedIdentityIndex, string selectedEmail, string identityName, string identityEmail, string identityUsage)
        {
            if (IsValid(identityName, identityEmail))
            {
                Identity identity = FormvIDsafe.Main.User.Vault.Identities[selectedEmail];

                identity.SetDetails(identityName, identityEmail, identityUsage);

                cmbIdentity.Items[selectedIdentityIndex] = identity.Name + " - " + identity.Email;

                GetBreachedData(identityEmail, true);
            }
        }
        
        private void GetBreachedData(string selectedEmail, bool useAPI)
        {
            Identity identity = FormvIDsafe.Main.User.Vault.Identities[selectedEmail];
            identity.GetBreaches(useAPI);

            Dictionary<string, string> breachedDomains = identity.BreachedDomains;

            DisplayBreaches(breachedDomains);
        }

        private void DisplayBreaches(Dictionary<string, string> domains)
        {
            lvBreachedData.Items.Clear();
            foreach (KeyValuePair<string, string> domain in domains)
            {
                ListViewItem lvi = new ListViewItem("");
                lvi.SubItems.Add(domain.Key);
                lvi.SubItems.Add(domain.Value);

                lvBreachedData.Items.Add(lvi);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteIdentity(cmbIdentity.SelectedItem.ToString());
        }

        private void cmbIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIdentityDetails(cmbIdentity.SelectedItem.ToString());
        }

        private void GetIdentities()
        {
            ResetDetails();
            cmbIdentity.Items.Clear();

            foreach (KeyValuePair<string, Identity> identityPair in FormvIDsafe.Main.User.Vault.Identities)
            {
                cmbIdentity.Items.Add(identityPair.Key);
            }
        }

        private void GetIdentityDetails(string selectedEmail)
        {
            ResetDetails();

            Identity identity = FormvIDsafe.Main.User.Vault.Identities[selectedEmail];

            GetBreachedData(selectedEmail, false);

            txtIdentityName.Text = identity.Name;
            txtIdentityEmail.Text = identity.Email;
            txtIdentityUsage.Text = identity.Usage;

            DisplayCredentialInformation(identity);
        }

        private void DisplayCredentialInformation(Identity identity)
        {
            identity.CalculateHealthScore();

            int safeCount = identity.SafeCredentials;
            int weakCount = identity.WeakCredentials;
            int conflictCount = identity.ConflictCredentials;
            int compromisedCount = identity.CompromisedCredentials;

            chartCredentials.Series["Credentials"].Points[0].SetValueXY("Safe", safeCount);
            chartCredentials.Series["Credentials"].Points[1].SetValueXY("Weak", weakCount);
            chartCredentials.Series["Credentials"].Points[2].SetValueXY("Conflicts", conflictCount);
            chartCredentials.Series["Credentials"].Points[3].SetValueXY("Compromised", compromisedCount);
            chartCredentials.Series["Credentials"].IsValueShownAsLabel = true;
        }

        private void DeleteIdentity(string selectedEmail)
        {
            FormvIDsafe.Main.User.Vault.DeleteIdentity(selectedEmail);

            cmbIdentity.Items.Remove(selectedEmail);

            ResetDetails();
        }

        private void ResetDetails()
        {
            ClearInputs();

            int selectedIdentityIndex = cmbIdentity.SelectedIndex;

            if (selectedIdentityIndex >= 0)
            {
                EnableIdentityComponents(true);

                FixColumnWidths();
            }
            else
            {
                EnableIdentityComponents(false);
            }
        }

        private void EnableIdentityComponents(bool enabled)
        {
            txtIdentityName.Enabled = enabled;
            txtIdentityEmail.Enabled = enabled;
            txtIdentityUsage.Enabled = enabled;

            btnSave.Enabled = enabled;
            btnDelete.Enabled = enabled;

            pnlIdentityComponents.Visible = enabled;
        }

        private void ClearInputs()
        {
            txtIdentityName.Clear();
            txtIdentityEmail.Clear();
            txtIdentityUsage.Clear();
        }

        private void FormIdentities_Resize(object sender, EventArgs e)
        {
            FixColumnWidths();
        }
        private void FixColumnWidths()
        {
            lvBreachedData.Columns[1].Width = lvBreachedData.Width / (lvBreachedData.Columns.Count - 1);
            lvBreachedData.Columns[2].Width = lvBreachedData.Width / (lvBreachedData.Columns.Count - 1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetBreachedData(cmbIdentity.SelectedItem.ToString(), true);
        }
    }
}
