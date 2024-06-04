using posystem.Model;
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
    public partial class formproducts : Sample
    {
        public formproducts()
        {
            InitializeComponent();
        }
        private void formproducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new fromNewProduct().ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = MainClass.Function.LoadProductsData(searchInput.Text);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Name";
            guna2DataGridView1.Columns[2].HeaderText = "Price";
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.RowTemplate.Height = 30;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null && guna2DataGridView1.CurrentRow.Index >= 0)
            {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value);
                if (id > 0)
                {
                    new fromNewProduct() { editID = id }.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
