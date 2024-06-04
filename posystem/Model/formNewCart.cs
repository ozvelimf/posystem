using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace posystem.Model
{
    public partial class formNewCart : Sample
    {
        public formNewCart()
        {
            InitializeComponent();
        }

        private void formNewCart_Load(object sender, EventArgs e)
        {
            LoadData();
            dialogTitle.Text = "Products List";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int userID = Function.sessionUserID;

            if (CartDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = CartDataGridView.SelectedRows[0];

                int product_id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                bool success = Function.SaveCartData(userID, product_id);
                if (success)
                {
                    MessageBox.Show("Product added to cart successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the product data.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void LoadData()
        {
            DataTable dt = MainClass.Function.LoadProductsData(searchInput.Text);
            CartDataGridView.DataSource = dt;
            CartDataGridView.Columns[0].HeaderText = "ID";
            CartDataGridView.Columns[1].HeaderText = "Name";
            CartDataGridView.Columns[2].HeaderText = "Price";
            CartDataGridView.ColumnHeadersHeight = 40;
            CartDataGridView.RowTemplate.Height = 30;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
