using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class FrmTabelsView : SampleView
    {
        public FrmTabelsView()
        {
            InitializeComponent();
            GetDataTables();
        }
        public void GetDataTables()
        {
            string query = "select * From Tabels where tabelName like '%" + txtSearch.Text + "%'";
            //ListBox lb = new ListBox();
            //lb.Items.Add(SR);
            //lb.Items.Add(Tname);
            DataBase.LoadData1(query, DataGridView1);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetDataTables();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            Utility.BlurBackGround(new FrmTabelsadd());
            GetDataTables();
         //   while (DataGridView1.Rows.Count > 0) DataGridView1.Rows.RemoveAt(0);
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //another way
            if (DataGridView1.Columns[e.ColumnIndex].Name.ToString() == "Update")
            {
                string id = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
                FrmTabelsadd f = new FrmTabelsadd();
                f.update = int.Parse(id) > 0 ? true : false;
                f.id = id;
                f.tablename = DataGridView1.Rows[e.RowIndex].Cells["Tname"].Value.ToString();
                f.ShowDialog();
                DataGridView1.Rows[e.RowIndex].Cells["Tname"].Value = f.guna2TextBox1.Text;
            }
            else
          if (DataGridView1.Columns[e.ColumnIndex].Name.ToString() == "Delete")
            {
                string id = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
                string query = "delete from tabels where tabelid=" + id;
                DataBase.UpdateData(query);
                DataGridView1.Rows[e.RowIndex].Visible = false;
                GetDataTables();
            }

            

        }
    }
}
