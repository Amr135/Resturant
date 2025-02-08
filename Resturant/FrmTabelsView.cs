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
            GetData();
        }
        public void GetData()
        {
            string query = "select * From Tabels where tabelName like '%" + txtSearch.Text + "%'";
            DataBase.LoadData1(query, DataGridView1);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTabelsadd f = new FrmTabelsadd();
            f.ShowDialog();
            GetData();
        }
    
       
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DataGridView1.Columns[e.ColumnIndex].Name.ToString() == "Update") {
            //    string id = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
            //    FrmTabelsadd f = new FrmTabelsadd();
            //    f.update=int.Parse(id)>0?true:false;
            //    f.id=id;
            //    f.tablename = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
            //    f.ShowDialog();
  
            //    GetData();
            //        }
            //else
          if (DataGridView1.Columns[e.ColumnIndex].Name.ToString() == "Delete") {
                string id = DataGridView1.Rows[e.RowIndex].Cells["SR"].Value.ToString();
                string query = "delete from tabels where tabelid=" + id;
                DataBase.UpdateData(query);
                GetData();
            }
        }
    }
}
