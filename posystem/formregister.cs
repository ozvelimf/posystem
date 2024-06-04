using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posystem
{
    public partial class formregister : Sample
    {
        public formregister()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;
            string repassword = textRepassword.Text;
            int id = 0;

            if (!Function.ValidateUserData(id, username, email, password, repassword))
            {
                MessageBox.Show("Please ensure all fields are correctly filled.");
                return;
            }
            else
            {
                int editID = 0;
                bool success = Function.SaveUserData(editID, username, email, !string.IsNullOrEmpty(password) ? password : null);
                if (success)
                {
                    MessageBox.Show("New user added successfully.");
                    new formlogin().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the user data.");
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new formlogin().Show();
            this.Hide();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
