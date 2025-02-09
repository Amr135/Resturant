using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.Model;

namespace Resturant.View
{
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "select * from Category where CatName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            DataBase.LoadData(query, DataGridView1, lb);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            Utility.BlurBackGround(new frmCategoryAdd());
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                frmCategoryAdd frm = new frmCategoryAdd();
                frm.id = Convert.ToInt32(DataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.txtName.Text = Convert.ToString(DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            
            if (DataGridView1.Columns[e.ColumnIndex].Name == "dgvDel")
            {
                int id = Convert.ToInt32(DataGridView1.CurrentRow.Cells["dgvID"].Value);
                string qry = "delete from Category where CatID= " + id + "";
                Hashtable ht = new Hashtable();
                DataBase.SQL(qry, ht);
                MessageBox.Show("Deleted Successfuly");
                GetData();
            }
         
        }
    }
}
