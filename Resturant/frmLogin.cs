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
            if (DataBase.checkLogin(txtUsername.Text,txtPassword.Text) == true) 
            {
                this.Hide();
                new FrmMain().Show();
            }
            else
            {
                Message.Show();
            }
               
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
