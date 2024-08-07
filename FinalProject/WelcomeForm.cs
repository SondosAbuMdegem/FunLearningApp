using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(WelcomeForm_Load);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Open LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Hide the WelcomeForm
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Open RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Hide the WelcomeForm
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
        }
    }
}
