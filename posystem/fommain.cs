using MainClass;
using posystem.View;
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
    public partial class fommain : Sample
    {
        public fommain()
        {
            InitializeComponent();
        }

        private void fommain_Load(object sender, EventArgs e)
        {
            dashboardUserText.Text = "User : " + Function.sessionUsername;
        }
    
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Function.sessionUsername = "";
            Function.sessionUserID = 0;
            new formlogin().Show();
            this.Hide();
        }

        private void AddControls(Form F)
        {
            CenterPanel.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(F);
            F.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            AddControls(new formUsers());
            title.Text = "USERS";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new formproducts());
            title.Text = "PRODUCTS";
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            AddControls(new formDashboard());
            title.Text = "DASHBOARD";
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            AddControls(new formcart());
            title.Text = "CART";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            AddControls(new formOrders());
            title.Text = "ORDERS";
        }
    }
}
