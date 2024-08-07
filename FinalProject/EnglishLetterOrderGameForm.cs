using System;
using System.Drawing;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace FinalProject
{
    public partial class EnglishLetterOrderGameForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private int currentLetterIndex;
        private readonly char[] englishLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public EnglishLetterOrderGameForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            this.currentLetterIndex = 0;
            labelPrompt.Text = "Type the letters in alphabetical order";
            this.Load += new EventHandler(EnglishLetterOrderGameForm_Load); // Add load event handler
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.ToUpper() == englishLetters[currentLetterIndex].ToString())
            {
                currentLetterIndex++;
                if (currentLetterIndex < englishLetters.Length)
                {
                    labelFeedback.Text = "Correct, keep going!";
                    textBoxInput.Clear();
                    UpdateCurrentLetter();
                }
                else
                {
                    labelFeedback.Text = "You won! You've earned 10 coins.";
                    coins += 10;
                    UpdateUserCoins();
                    textBoxInput.Enabled = false; // Disable further input after game is won
                }
            }
            else
            {
                labelFeedback.Text = "Incorrect, try again.";
            }
        }

        private void UpdateCurrentLetter()
        {
            if (currentLetterIndex < englishLetters.Length)
            {
                labelPrompt.Text = $"Next letter: {englishLetters[currentLetterIndex]}";
            }
        }

        private void UpdateUserCoins()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\m1571\source\repos\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        worksheet.Cells[row, 6].Value = coins; // Assuming the coins are in the 6th column
                        package.Save();
                        break;
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishGamesForm englishGamesForm = new EnglishGamesForm(username, userId, email, coins, products);
            englishGamesForm.ShowDialog();
            this.Close();
        }

        private void EnglishLetterOrderGameForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            labelPrompt.TextAlign = ContentAlignment.MiddleRight;
            labelFeedback.TextAlign = ContentAlignment.MiddleRight;
        }

        private void labelFeedback_Click(object sender, EventArgs e)
        {
        }
    }
}
