using Guna.UI2.WinForms.Enums;
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
    public partial class FrmPos : Form
    {
        public FrmPos()
        {
            InitializeComponent();
        }

        private void FrmPos_Load(object sender, EventArgs e)
        {
            FillPanelCategory();
            fillPanelItem();
        }
        private void FillPanelCategory()
        {
            CategoryPanel.Controls.Clear();
            string[] cate = { "Drink", "Meat", "Food","Burger" };
            int yOffset = 0;

            foreach (string c in cate)
            {
                Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
                button.Text = c;
                button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                button.Size = new Size(184, 56);
                button.FillColor = Color.Teal;
                button.Location = new Point(0, yOffset);
                CategoryPanel.Controls.Add(button);
                yOffset += button.Height + 5;
                button.Click += ShowSearchItemOrCategory;
            }
        }
        private USproducts AddOneItem(SqlDataReader reader)
        {
            USproducts U = new USproducts()
            {
                Uid = (int)reader["itid"],
                UName = (string)reader["itName"],
                UPrice = (int)reader["itPrice"],
                UCategory = (string)reader["itCategory"],
                Uimage = Image.FromStream(new MemoryStream((byte[])reader["itimage"]))
                
            };
 
            U.onselect += (s, e) =>
            {
                bool q = true;
                var W = (USproducts)s;
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    if (W.Uid == Convert.ToInt32(row.Cells["Dgvid"].Value))
                    {
                        row.Cells["DgvQut"].Value = int.Parse(row.Cells["DgvQut"].Value.ToString()) + 1;
                        row.Cells["DgvAmont"].Value = int.Parse(row.Cells["DgvAmont"].Value.ToString()) + int.Parse(row.Cells["DgvPrice"].Value.ToString());
                        q= false;
                    }
                  
                }
                if(q)addtoDatagridview(W);

            };
            
            return U;
        }
        private void addtoDatagridview(USproducts us)
        {
            
                DataGridView1.Rows.Add(new object[] { us.Uid, us.Uid,us.UName,1,us.UPrice, us.UPrice });
             
            


        }
        private void fillPanelItem()
        {
            SqlConnection con = new SqlConnection(DataBase.str_connection);
            string query = "Select *from Items";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    ItemesPanel.Controls.Add(AddOneItem(reader));
                }
                con.Close();
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void  ShowSearchItemOrCategory(object sender,EventArgs e)
        {
           
             var T = (Guna.UI2.WinForms.Guna2Button)sender; 
           
            foreach (var i in ItemesPanel.Controls)
            {
                var b = (USproducts)i;
                b.Visible = T.Text.ToLower().Contains(b.UCategory.ToLower());
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var i in ItemesPanel.Controls)
            {
                var b = (USproducts)i;
                b.Visible = guna2TextBox1.Text.ToLower().Contains(b.UName.Trim().ToLower());
            }
        }
    }
}
