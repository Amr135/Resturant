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
        public bool update = false;
        public string tablename;
        public string id;
        public FrmTabelsadd()
        {
            InitializeComponent();
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string query;
            if (!update)
            {
               query = "insert into tabels values('" + guna2TextBox1.Text + "')";
            }
            else {
                 query = "Update tabels set tabelname=" + tablename + "where tabelid=" + id;
            }
                DataBase.UpdateData(query);
       
        }
    }
}
