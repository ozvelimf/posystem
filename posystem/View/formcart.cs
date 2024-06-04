using MainClass;
using posystem.Model;
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

namespace posystem.View
{
    public partial class formcart : Sample
    {
        public formcart()
        {
            InitializeComponent();
        }

        public decimal cartTotalPay;
        public int userID;
        public string selectedUsername;
        private void formcart_Load(object sender, EventArgs e)
        {
            LoadCartData();
            ConfigureDataGridView();
            CheckCurrentUser();
            CalculateTotalPay();
        }

        private void CheckCurrentUser()
        {
            if (selectedUsername == Function.sessionUsername)
            {
                btnPay.Visible = true;
            }
            else
            {
                btnPay.Visible = false;
            }
                
        }

        public void LoadCartData()
        {
            DataTable dt = Function.LoadUserData("");
            selectUser.DataSource = dt;
            selectUser.DisplayMember = "username";
            selectUser.ValueMember = "id";

            if (selectUser.Items.Count > 0)
            {
                foreach (DataRowView item in selectUser.Items)
                {
                    if (item["username"].ToString() == Function.sessionUsername || item["id"].ToString() == Function.sessionUserID.ToString())
                    {
                        selectUser.SelectedItem = item;
                        selectedUsername = item["username"].ToString();
                        break;
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new formNewCart().ShowDialog();
            LoadCartData();
        }



        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            List<int> productIds = GetSelectedProductIds();

            new formPayment() { totalAmount = cartTotalPay, user_id = userID, productList = productIds }.ShowDialog();
            LoadCartData();
        }

        private void selectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectUser.SelectedItem != null)
            {
                DataRowView selectedUser = (DataRowView)selectUser.SelectedItem;
                if (selectedUser != null)
                {
                    int userId;
                    if (int.TryParse(selectedUser["id"].ToString(), out userId))
                    {
                        DataTable cartData = Function.GetUserCart(userId);
                        userID = userId;
                        selectedUsername = selectedUser["username"].ToString();
                        CheckCurrentUser();

                        guna2DataGridView1.Rows.Clear();
                        foreach (DataRow row in cartData.Rows)
                        {
                            int productId = Convert.ToInt32(row["product_id"]);
                            DataTable productData = Function.GetProductData(productId);

                            if (productData.Rows.Count > 0)
                            {
                                DataRow productRow = productData.Rows[0];
                                guna2DataGridView1.Rows.Add(row["id"], productRow["Name"], productRow["Price"], "Delete");
                            }
                        }
                        CalculateTotalPay();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user ID.");
                    }
                }
            }
        }

        private List<int> GetSelectedProductIds()
        {
            List<int> productIds = new List<int>();

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int productId = Convert.ToInt32(row.Cells["ID"].Value);
                    productIds.Add(productId);
                }
            }

            return productIds;
        }

        private void ConfigureDataGridView()
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.RowTemplate.Height = 30;
        }

        private void CalculateTotalPay()
        {
            decimal totalPayData = 0;
            decimal price;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {

                    if (row.Cells["price"].Value != null && Decimal.TryParse(row.Cells["price"].Value.ToString(), out price))
                    {
                        totalPayData += price;
                    }
                }
            }

            cartTotalPay = totalPayData;
            totalPay.Text = totalPayData.ToString() + " ₺";
            
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView1.Columns["process"].Index && e.RowIndex != -1)
            {
                int selectedId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                bool success = Function.DeleteCartItem(selectedId);

                if (success) 
                {
                    MessageBox.Show("Cart Item deleted successfully.");
                    LoadCartData();
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the cart item.");
                }

            }
        }
    }
}
