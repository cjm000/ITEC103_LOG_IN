namespace ITEC103_LOG_IN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string userName = "admin"; string password = "admin";

            if (txtUser.Text == userName && txtPassword.Text == password)
            {
                this.Hide();
                new welcome().Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txtUser.Text = ""; txtPassword.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new register().Show();
        }
    }
}
