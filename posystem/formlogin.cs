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
    public partial class formlogin : Sample
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (Function.ValidateLogin(username, password))
            {
                Function.sessionUsername = username;
                int userID = Function.getUserID(username);
                Function.sessionUserID = userID;
                new fommain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new formregister().Show();
            this.Hide();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
