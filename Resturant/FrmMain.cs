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
          frmCategoryView f=  new frmCategoryView();
            AddControls(f);
        }
    }
}
