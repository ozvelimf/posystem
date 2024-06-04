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

namespace posystem.Model
{
    public partial class fromNewProduct : Sample
    {
        public fromNewProduct()
        {
            InitializeComponent();
        }
        public int editID = 0;

        private void fromNewProduct_Load(object sender, EventArgs e)
        {
            if (editID > 0)
            {
                DataTable productData = Function.GetProductData(editID);
                if (productData.Rows.Count > 0)
                {
                    DataRow row = productData.Rows[0];
                    nameInput.Text = row["Name"].ToString();
                    priceInput.Text = row["Price"].ToString();
                    dialogTitle.Text = "Product: " + row["Name"].ToString();
                }
            }
            else
            {
                dialogTitle.Text = "New Product";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string priceText = priceInput.Text;
            decimal price;

            if (!decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            bool success = Function.SaveProductData(editID, name, price);
            if (success)
            {
                MessageBox.Show(editID > 0 ? "Product updated successfully." : "New Product added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the product data.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (editID > 0)
            {
                bool success = Function.DeleteProductData(editID);
                if (success)
                {
                    MessageBox.Show("Product deleted successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the product.");
                }
            }
        }
    }
}
