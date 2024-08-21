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
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.ToUpper() == englishLetters[currentLetterIndex].ToString())
            {
                currentLetterIndex++;
                if (currentLetterIndex < englishLetters.Length)
                {
                    int centerX = 266; 
                    int yPosition = 210;
                    labelFeedback.Font = new Font("Arial", 10, FontStyle.Bold); 
                    labelFeedback.ForeColor = Color.Green; 
                    labelFeedback.BackColor = Color.LightYellow; 
                    labelFeedback.TextAlign = ContentAlignment.MiddleCenter; 
                    labelFeedback.BorderStyle = BorderStyle.FixedSingle; 
                    labelFeedback.Padding = new Padding(5);                            
                    labelFeedback.Location = new Point(centerX , yPosition);
                    labelFeedback.Text = "Correct, keep going!";
                    textBoxInput.Clear();
                    UpdateCurrentLetter();
                }
                else
                {
                    int centerX = 266;
                    int yPosition = 210;
                    labelFeedback.Font = new Font("Arial", 10, FontStyle.Bold); // Set font style, size, and weight
                    labelFeedback.ForeColor = Color.Green; // Set the text color
                    labelFeedback.BackColor = Color.LightYellow; // Set the background color
                    labelFeedback.TextAlign = ContentAlignment.MiddleCenter; // Center the text within the label
                    labelFeedback.BorderStyle = BorderStyle.FixedSingle; // Add a border to the label
                    labelFeedback.Padding = new Padding(5);
                    labelFeedback.Location = new Point(centerX, yPosition);
                    labelFeedback.Text = "You won! You've earned 10 coins.";
                    coins += 10;
                    UpdateUserCoins();
                    textBoxInput.Enabled = false; // Disable further input after game is won
                }
            }
            else
            {
                int centerX = 266;
                int yPosition = 210;
                labelFeedback.Font = new Font("Arial", 10, FontStyle.Bold); // Set font style, size, and weight
                labelFeedback.ForeColor = Color.Green; // Set the text color
                labelFeedback.BackColor = Color.LightYellow; // Set the background color
                labelFeedback.TextAlign = ContentAlignment.MiddleCenter; // Center the text within the label
                labelFeedback.BorderStyle = BorderStyle.FixedSingle; // Add a border to the label
                labelFeedback.Padding = new Padding(5);
                labelFeedback.Location = new Point(centerX, yPosition);
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
            labelPrompt.TextAlign = ContentAlignment.MiddleRight;
            labelFeedback.TextAlign = ContentAlignment.MiddleRight;
        }

        private void EnglishLetterOrderGameForm_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
