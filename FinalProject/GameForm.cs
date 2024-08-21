using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GameForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;

        public GameForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
        }

        private void buttonHebrewGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            HebrewGamesForm hebrewGamesForm = new HebrewGamesForm(username, userId, email, coins, products);
            hebrewGamesForm.ShowDialog();
            this.Show();
        }

        private void buttonMathGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathGamesForm mathGamesForm = new MathGamesForm(username, userId, email, coins, products);
            mathGamesForm.ShowDialog();
            this.Show();
        }

        private void buttonEnglishGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishGamesForm englishGamesForm = new EnglishGamesForm(username, userId, email, coins, products);
            englishGamesForm.ShowDialog();
            this.Show();
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(username, userId, email, coins, products);
            mainForm.ShowDialog();
            this.Close();
        }

        private void UpdateUserCoins(string username, int additionalCoins)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\m1571\OneDrive\Desktop\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        int currentCoins = int.Parse(worksheet.Cells[row, 6].Text);
                        worksheet.Cells[row, 6].Value = currentCoins + additionalCoins;
                        package.Save();
                        break;
                    }
                }
            }
        }
    }
}