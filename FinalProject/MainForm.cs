using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;

        public MainForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;

            buttonGames.Click += buttonGames_Click;
            buttonShop.Click += buttonShop_Click;
            buttonUserInfo.Click += buttonUserInfo_Click;
            buttonExit.Click += buttonExit_Click;
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GameForm gameForm = new GameForm(username, userId, email, coins, products))
            {
                gameForm.ShowDialog();
            }
            this.Show();
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ShopForm shopForm = new ShopForm(username, userId, email, coins, products))
            {
                shopForm.ShowDialog();
            }
            this.Show();
        }

        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (UserForm userForm = new UserForm(username, userId, email, coins, products))
            {
                userForm.ShowDialog();
            }
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonShop_Click_1(object sender, EventArgs e)
        {

        }
    }
}
