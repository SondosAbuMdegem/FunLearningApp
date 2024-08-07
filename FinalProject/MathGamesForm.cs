using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MathGamesForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;

        public MathGamesForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
        }

        private void buttonBackToGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(username, userId, email, coins, products);
            gameForm.ShowDialog();
            this.Close();
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdditionGameForm additionGameForm = new AdditionGameForm(username, userId, email, coins, products);
            additionGameForm.ShowDialog();
            this.Close();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubtractionGameForm subtractionGameForm = new SubtractionGameForm(username, userId, email, coins, products);
            subtractionGameForm.ShowDialog();
            this.Close();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiplicationGameForm multiplicationGameForm = new MultiplicationGameForm(username, userId, email, coins, products);
            multiplicationGameForm.ShowDialog();
            this.Close();
        }

        private void MathGamesForm_Load(object sender, EventArgs e)
        {
            // You can add any additional initialization code here if needed
        }
    }
}
