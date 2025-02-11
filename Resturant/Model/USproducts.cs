using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class USproducts : UserControl
    {
        public event EventHandler onselect = null;
        public USproducts()
        {
            InitializeComponent();
        }
        public int Uid { get; set; }
        public string UName { get { return label1.Text; } set { label1.Text = value; } }
        public string UCategory { get; set; }
        public int UPrice { get; set; }
        public Image Uimage { get { return guna2PictureBox1.Image; } set { guna2PictureBox1.Image = value; } }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            onselect?.Invoke(this, e);
        }
    }
}
