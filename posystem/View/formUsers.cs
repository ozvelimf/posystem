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
    public partial class formUsers : Sample
    {
        public formUsers()
        {
            InitializeComponent();
        }

        private void formUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = MainClass.Function.LoadUserData(searchInput.Text);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Username";
            guna2DataGridView1.Columns[2].HeaderText = "Email";
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.RowTemplate.Height = 30;
        }


        public virtual void searchInput_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public virtual void btnNew_Click(object sender, EventArgs e)
        {
            new formNewUser().ShowDialog();
            LoadData();
        }

        public virtual void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null && guna2DataGridView1.CurrentRow.Index >= 0)
            {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value);
                if (id > 0)
                {
                    new formNewUser() { editID = id }.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
