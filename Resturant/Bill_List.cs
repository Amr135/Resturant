using Guna.UI2.WinForms;
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

namespace Resturant
{
    public partial class Bill_List : SampleAdd
    {
        public Bill_List()
        {
            InitializeComponent();
            Get_Data();
        }
        void Get_Data()
        {
            Dgv_Bills_List.Rows.Clear();
            string qry = "select Bills_Details.ID,OrderDetails.Ordertype,OrderDetails.Tnumber,Bills_Details.BIll_State ,Bills_Details.Price from Bills_Details inner join OrderDetails on Bills_Details.id=OrderDetails.Idorder";
            SqlCommand command = new SqlCommand(qry, DataBase.conn);
            try
            {
                DataBase.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader Reader = command.ExecuteReader();
                dt.Load(Reader);
                int counter = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    Dgv_Bills_List.Rows.Add(new object[] { counter++, dr["id"], dr["OrderType"], dr["Tnumber"], dr["Bill_State"], dr["Price"] });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { DataBase.conn.Close(); }
        }
        bool Confirm_ask()
        {
          return  (MessageBox.Show("Are you Sure", "Confirm", MessageBoxButtons.OKCancel)==DialogResult.OK);
        }
        private void Dgv_Bills_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Bills_List.ColumnCount - 1)
            {
                if (Confirm_ask())
                {
                    int id = Convert.ToInt32(Dgv_Bills_List.Rows[e.RowIndex].Cells["Dgv_Id_Order"].Value);
                    string Table_Name = "Bills_Details";
                    string Table_ID = "Id";

                    DataBase.Delete_Row(id, Table_Name, Table_ID);
                    Get_Data();
                    //send data to  report (DataBase)
                }
            }
        }
    }
}
