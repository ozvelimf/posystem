using Guna.UI2.WinForms;
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

namespace posystem.View
{
    public partial class formOrders : Sample
    {
        public formOrders()
        {
            InitializeComponent();
        }

        public decimal totalAmount = 0;

        private void formOrders_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string userData;
            int userID;
            DataTable dt;
            if (searchInput.Text == "")
            {
                dt = Function.LoadOrdersData(searchInput.Text);
            }
            else 
            {
                int.TryParse(searchInput.Text, out userID);
                int user = Function.getUserID(searchInput.Text);
                dt = Function.LoadOrdersData(user.ToString());
            }

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();
                DataGridViewRow dgvRow = guna2DataGridView1.Rows[rowIndex];

                dgvRow.Cells["id"].Value = row["id"];
                userData = row["user_id"].ToString();
                int.TryParse(userData, out userID);
                userData = Function.getUsername(userID);
                dgvRow.Cells["username"].Value = userData;
                dgvRow.Cells["price"].Value = row["price"];
            }

            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.RowTemplate.Height = 30;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            LoadData();
        }
    }
}
