using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant.View;

namespace Resturant
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        private static FrmMain _obj;
        public static FrmMain Instance { get { if (_obj == null) _obj = new FrmMain(); return _obj; } }
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public void AddControls(Form f)
        {
            CentralPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CentralPanel.Controls.Add(f);
            f.Show();
        }

        private void btnCatogries_Click(object sender, EventArgs e)
        {
            frmCategoryView f = new frmCategoryView();
            AddControls(f);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label1.Text = DataBase.USER;
            _obj = this;
        }

        private void BtnTablesView_Click(object sender, EventArgs e)
        {
            FrmTabelsView f = new FrmTabelsView();
            AddControls(f);
        }

     

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FrmPos f= new FrmPos();
            f.ShowDialog();
        }
    }
}
