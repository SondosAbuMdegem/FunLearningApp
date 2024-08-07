using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class HebrewGamesForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;

        public HebrewGamesForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
        }

        private void buttonLetterOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            HebrewLetterOrderGameForm hebrewLetterOrderGameForm = new HebrewLetterOrderGameForm(username, userId, email, coins, products);
            hebrewLetterOrderGameForm.ShowDialog(); 
            this.Close();   
        }

        private void buttonWordMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            HebrewWordMatchGameForm HebrewWordMatchGameForm = new HebrewWordMatchGameForm(username, userId, email, coins, products);
            HebrewWordMatchGameForm.ShowDialog();
            this.Close();
        }

        private void buttonMemoryGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemoryGameForm MemoryGameForm = new MemoryGameForm(username, userId, email, coins, products);
            MemoryGameForm.ShowDialog();
            this.Close();
        }

        private void buttonBackToGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(username, userId, email, coins, products);
            gameForm.ShowDialog();
            this.Close();
        }
    }
}
