using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EnglishGamesForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;

        public EnglishGamesForm(string username, string userId, string email, int coins, int products)
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

        private void buttonLetterOrder_Click(object sender, EventArgs e)
        {
                this.Hide();
                EnglishLetterOrderGameForm letterOrderGameForm = new EnglishLetterOrderGameForm(username, userId, email, coins, products);
                letterOrderGameForm.ShowDialog();
                this.Close();

        }

        private void buttonLetterMatch_Click(object sender, EventArgs e)
        {
                this.Hide();
                EnglishWordMatchGameForm wordMatchGameForm = new EnglishWordMatchGameForm(username, userId, email, coins, products);
                wordMatchGameForm.ShowDialog();
                this.Close();
        }

        private void buttonMemoryGame_Click(object sender, EventArgs e)
        {
                this.Hide();
                MemoryGameFormEng memoryGameFormEng = new MemoryGameFormEng(username, userId, email, coins, products);
                memoryGameFormEng.ShowDialog();
                this.Close();
        }

        private void EnglishGamesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
