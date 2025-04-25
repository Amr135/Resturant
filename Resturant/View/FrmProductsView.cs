using Resturant.Model;
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

namespace Resturant.View
{
    public partial class FrmProductsView : SampleView
    {
        public FrmProductsView()
        {
            InitializeComponent();
            GetData();
        }
        void GetData()
        {
        DataGridView1.Rows.Clear();
            string qry = "select *from Items";
            DataBase.conn.Open();
            SqlCommand cmd = new SqlCommand(qry, DataBase.conn);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridView1.Rows.Add(reader["Itid"], reader["itName"], reader["itPrice"]);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { DataBase.conn.Close(); }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Add_Porduct_Details Pro = new Add_Porduct_Details();
            Utility.BlurBackGround(Pro);
            GetData();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==DataGridView1.Columns.Count-1 )
            { //delete 
                if (MessageBox.Show("Are You Sure From Delete this Product","Delete",MessageBoxButtons.OKCancel)==DialogResult.OK) {
                    int id = (int)DataGridView1.Rows[e.RowIndex].Cells["DgvID"].Value;
                    string qry = $"delete from items where itid={id}";
                     
                    DataBase.UpdateData(qry);
                    GetData(); }
            }
            if (e.ColumnIndex == DataGridView1.Columns.Count - 2)
            {
                //update
                int id = (int)DataGridView1.Rows[e.RowIndex].Cells["DgvID"].Value;

                Add_Porduct_Details Pro = new Add_Porduct_Details(id);
                Utility.BlurBackGround(Pro);
                GetData();
            }
            
        }
    }
}
