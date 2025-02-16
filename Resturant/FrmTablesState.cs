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
    public partial class FrmTablesState : Form
    {
        public FrmTablesState()
        {
            InitializeComponent();
            FillPanelTables();
        }
        private void FillPanelTables()
        {
            string query = "Select *from Tables";
            SqlCommand command = new SqlCommand(query, DataBase.conn);
            try { DataBase.conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    Guna.UI2.WinForms.Guna2Button B = new Guna.UI2.WinForms.Guna2Button();
                    B.Tag = reader["Tstate"].ToString();
                    B.FillColor = Convert.ToBoolean(B.Tag)?Color.Red:Color.Teal;

                    B.Text = reader["Tablename"].ToString();
                    B.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    B.Click += (sender, e) =>
                    {
                        foreach (var control in flowLayoutPanel1.Controls)
                        {

                            if (control is Guna.UI2.WinForms.Guna2Button button)
                            {
                            if (!Convert.ToBoolean(button.Tag)) button.FillColor = Color.Teal; 
                            }
                        }
                        B.FillColor = Color.Red;
                        LbTableChoosen.Text = B.Text;
                    };
                    flowLayoutPanel1.Controls.Add(B);
                }
                DataBase.conn.Close();
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
            }


    }
}
