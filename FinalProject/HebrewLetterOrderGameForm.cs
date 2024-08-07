using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace FinalProject
{
    public partial class HebrewLetterOrderGameForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private int currentLetterIndex;
        private readonly char[] hebrewLetters = new char[]
        {
            'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת'
        };

        public HebrewLetterOrderGameForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            this.currentLetterIndex = 0;
            labelPrompt.Text = "תרשום את האותיות לפי הסדר";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == hebrewLetters[currentLetterIndex].ToString())
            {
                currentLetterIndex++;
                if (currentLetterIndex < hebrewLetters.Length)
                {
                    labelFeedback.Text = "נכון, תמשיך";
                    textBoxInput.Clear();
                    UpdateCurrentLetter();
                }
                else
                {
                    labelFeedback.Text = "ניצחת! קיבלת 10 מטבעות";
                    coins += 10;
                    UpdateUserCoins();
                    textBoxInput.Enabled = false; // Disable further input after game is won
                }
            }
            else
            {
                labelFeedback.Text = "לא נכון, נסה שוב";
            }
        }

        private void UpdateCurrentLetter()
        {
            if (currentLetterIndex < hebrewLetters.Length)
            {
                labelPrompt.Text = "האות הבאה: ";
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
            HebrewGamesForm hebrewGamesForm = new HebrewGamesForm(username, userId, email, coins, products);
            hebrewGamesForm.ShowDialog();
            this.Close();
        }
    }
}
