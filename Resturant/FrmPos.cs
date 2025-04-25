using Guna.UI2.WinForms.Enums;
using System;
using System.Collections;
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
        public int Price = 0;
        public string OrderType = "";
        private void FrmPos_Load(object sender, EventArgs e)
        {
            FillPanelCategory();
            fillPanelItem();
            TxtTotal.Text = "0";
        }
        private void FillPanelCategory()
        {
            CategoryPanel.Controls.Clear();
          List<string> cate = GET_Name_Category("select Category_Name from Category");
            int yOffset = 0;
           List<string> GET_Name_Category(string qry)
            { List<string> L_Category = new List<string>();
                try
                {
                DataBase.conn.Open();
                SqlDataReader Reader=new SqlCommand(qry ,DataBase.conn).ExecuteReader();
                    while (Reader.Read())
                    {
                        L_Category.Add(Reader["Category_Name"].ToString());
                    }
              
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { DataBase.conn.Close(); }
                return L_Category;
            }
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
                        Price -= int.Parse(row.Cells["DgvAmont"].Value.ToString());
                        row.Cells["DgvQut"].Value = int.Parse(row.Cells["DgvQut"].Value.ToString()) + 1;
                        row.Cells["DgvAmont"].Value = int.Parse(row.Cells["DgvAmont"].Value.ToString()) + int.Parse(row.Cells["DgvPrice"].Value.ToString());
                        TxtTotal.Text = (Price += int.Parse(row.Cells["DgvAmont"].Value.ToString())).ToString();
                        q = false;
                    }
                }
                if (q) addtoDatagridview(W);
            };
            return U;
        }
        private void addtoDatagridview(USproducts us)
        {

            DataGridView1.Rows.Add(new object[] { us.Uid, us.Uid, us.UName, 1, us.UPrice, us.UPrice });

            TxtTotal.Text = (Price += int.Parse(DataGridView1.Rows[DataGridView1.Rows.Count - 1].Cells["DgvAmont"].Value.ToString())).ToString();
            TxtTotal.Text = (Price += int.Parse(DataGridView1.Rows[DataGridView1.Rows.Count - 1].Cells["DgvAmont"].Value.ToString())).ToString();

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
        private void ShowSearchItemOrCategory(object sender, EventArgs e)
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
                b.Visible = b.UName.ToLower().Contains(guna2TextBox1.Text.ToLower());
            }
        }
        private void resete()
        {
            LbTable.Text = "";
            LbWaiter.Text = "";
            DataGridView1.Rows.Clear();
            TxtTotal.Text = "0";
            LbWaiter.Visible =
            LbTable.Visible = false;
            OrderType = "";

        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            resete();
        }

        private void BtnDelevery_Click(object sender, EventArgs e)
        {
            // resete();
            OrderType = "Delevery";

        }

        private void BtnTakeaway_Click(object sender, EventArgs e)
        {
            // resete();
            OrderType = "Take away";
        }

        private void BtnDinin_Click(object sender, EventArgs e)
        {
            OrderType = "Din in";
            FrmTablesState F = new FrmTablesState();
            F.ShowDialog();
            LbTable.Text = F.LbTableChoosen.Text;
            if (LbTable.Text != string.Empty) LbTable.Visible = true;
        }

        private void BtnKot_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Item was Choosed Yet ,Pleas Choose on Item At least");
                return;
            }
            if (OrderType == "")
            {
                MessageBox.Show("Please, Choose the Type of Order");
                return;
            }
            if (SendOrderDetailstoDatabase())
            {
                if (LbTable.Text != "") DataBase.UpdateData("Update Tables set Tstate=1 where  Tablename='" + LbTable.Text + "'");
                MessageBox.Show("success order");
                resete();
            }
            else
                MessageBox.Show("failed order");
        }
        private bool SendOrderDetailstoDatabase()
        {

            SqlCommand command;
            string query = "select  Itname from Items";
            Dictionary<string, int> Ht = new Dictionary<string, int>();
            command = new SqlCommand(query, DataBase.conn);
            try
            {
                string comqueryone = "", comquerytwo = "";
                string comquery1 = "", comquery2 = "";
                DataBase.conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) Ht[reader["itname"].ToString().ToLower()] = 0;
                reader.Close();
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    Ht[row.Cells["DgvName"].Value.ToString().ToLower()] = int.Parse(row.Cells["DgvQut"].Value.ToString());
                }
                foreach (KeyValuePair<string, int> I in Ht)
                {
                    comqueryone += I.Key + ",";
                    comquerytwo += "@" + I.Key + ",";
                }
                comquery1 = comqueryone.Substring(0, comqueryone.Length - 1);
                comquery2 = comquerytwo.Substring(0, comquerytwo.Length - 1);


                query = "insert into orderDetails  (" + comquery1 + ",Tnumber,orderType,price) Values(" + comquery2 + ",@Tnumber,@orderType,@Price)";

                command = new SqlCommand(query, DataBase.conn);
                foreach (KeyValuePair<string, int> I in Ht)
                {
                    command.Parameters.AddWithValue("@" + I.Key, I.Value);
                }

                command.Parameters.AddWithValue("@Tnumber", LbTable.Text);
                command.Parameters.AddWithValue("@orderType", OrderType);
                command.Parameters.AddWithValue("@Price", Price);

                command.ExecuteNonQuery();
                DataBase.conn.Close();
                return true;
            }
            catch
            (Exception ex)
            { MessageBox.Show(ex.Message); DataBase.conn.Close(); return false; }
        }

        private void BtnBillList_Click(object sender, EventArgs e)
        {
            Bill_List bill_List = new Bill_List();
             Utility.BlurBackGround(bill_List);
        }
    }
}
