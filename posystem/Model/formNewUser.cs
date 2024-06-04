using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posystem.Model
{
    public partial class formNewUser : Sample
    {
        public formNewUser()
        {
            InitializeComponent();
        }

        public int editID = 0;

        private void formNewUser_Load(object sender, EventArgs e)
        {
            if (editID > 0)
            {
                DataTable userData = Function.GetUserData(editID);
                if (userData.Rows.Count > 0)
                {
                    DataRow row = userData.Rows[0];
                    usernameInput.Text = row["Username"].ToString();
                    emailInput.Text = row["Email"].ToString();
                    dialogTitle.Text = "User: " + row["Username"].ToString();
                }
            }
            else
            {
                dialogTitle.Text = "New User";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (editID > 0)
            {
                bool success = Function.DeleteUserData(editID);
                if (success)
                {
                    MessageBox.Show("User deleted successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the user.");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string email = emailInput.Text;
            string password = passwordInput.Text;
            string repassword = repasswordInput.Text;

            if (!Function.ValidateUserData(editID, username, email, password, repassword))
            {
                MessageBox.Show("Please ensure all fields are correctly filled.");
                return;
            }

            bool success = Function.SaveUserData(editID, username, email, !string.IsNullOrEmpty(password) ? password : null);
            if (success)
            {
                MessageBox.Show(editID > 0 ? "User updated successfully." : "New user added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the user data.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
