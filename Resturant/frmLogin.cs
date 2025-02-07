namespace Resturant
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //database connection
            MessageBox.Show("database1", "database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
          new FrmMain().Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
