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

namespace Resturant.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into Category Values(@Name)";
            }
            else
            {
                qry = "Update Category set CatName=@Name where CatID=@id";
            }
            Hashtable ht=new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            if(DataBase.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfuly");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }

        }

    }
}
