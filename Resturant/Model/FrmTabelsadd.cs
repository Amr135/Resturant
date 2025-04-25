using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Resturant
{
    public partial class FrmTabelsadd : SampleAdd
    {
        private bool update = false;
        public string tablename;
        private string id;
        public FrmTabelsadd()
        {
            InitializeComponent();
        
        }
        public FrmTabelsadd(bool Update,string id)
        {
            InitializeComponent();
            this.update = Update;
            this.id = id;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string query;
            if (!update)
            {
               query = "insert into tables(TableName) values('" + guna2TextBox1.Text + "')";
            }
            else {
                 query = "Update tables set tablename='" + guna2TextBox1.Text + "'where tableid=" + id;
                tablename = guna2TextBox1.Text;
            }
                DataBase.UpdateData(query);
            MessageBox.Show("Saved  Successfuly");
            guna2TextBox1.Text = "";

        }
    }
}
