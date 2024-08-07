using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace FinalProject
{
    public partial class EnglishWordMatchGameForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private int currentImageIndex;
        private readonly string[] imageFiles = new string[]
        {
            "dog.jpg", "cat.jpg", "red.jpg", "five.jpg", "tree.jpg"
        };
        private readonly string[] correctWords = new string[]
        {
            "dog", "cat", "red", "five", "tree"
        };

        public EnglishWordMatchGameForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            this.currentImageIndex = 0;
            LoadNextImage();
            this.Load += new EventHandler(EnglishWordMatchGameForm_Load); // Add load event handler
        }

        private void LoadNextImage()
        {
            if (currentImageIndex < imageFiles.Length)
            {
                pictureBox.ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageFiles[currentImageIndex]);
                labelFeedback.Text = "";
            }
            else
            {
                labelFeedback.Text = "You won! You've earned 10 coins.";
                coins += 10;
                UpdateUserCoins();
                comboBoxWords.Enabled = false;
                buttonSubmit.Enabled = false;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxWords.SelectedItem == null)
            {
                labelFeedback.Text = "Select a word from the list.";
                return;
            }

            if (comboBoxWords.SelectedItem.ToString() == correctWords[currentImageIndex])
            {
                currentImageIndex++;
                LoadNextImage();
            }
            else
            {
                labelFeedback.Text = "Incorrect, try again.";
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

        private void EnglishWordMatchGameForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            labelFeedback.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
