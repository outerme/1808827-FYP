﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIDsafe
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginAsync(txtName.Text, txtPassword.Text);
        }

        /// <summary>
        /// Tries to login to an account
        /// </summary>
        private async void LoginAsync(string name, string password)
        {
            if (AccountValidator.IsLoginValid(name, password))
            {
                EnableLoginComponents(false);

                bool canLogin = await Task.Run(() =>             
                    MasterAccount.User.TryLogin(name, password)
                );

                if (canLogin.Equals(true))
                {
                    OpenHome();
                }
                else
                {
                    NotificationManager.ShowError("Login error", "Account doesn't exist or wrong password");
                }

                EnableLoginComponents(true);
            }
        }

        /// <summary>
        /// Opens the home form
        /// </summary>
        private void OpenHome()
        {
            FormHome form = new FormHome();
            form.Show();

            ParentForm.Hide();
        }

        /// <summary>
        /// Enables or disables form components
        /// </summary>
        private void EnableLoginComponents(bool enable)
        {
            btnLogin.Enabled = enable;
            btnRegister.Enabled = enable;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormvIDsafe.OpenChildForm(new FormRegister());
        }
    }
}
