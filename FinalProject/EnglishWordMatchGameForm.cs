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
        }

        private void LoadNextImage()
        {
            if (currentImageIndex < imageFiles.Length)
            {
                pictureBox.ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageFiles[currentImageIndex]);
                
            }
            else
            {
                int centerX = 110;
                int yPosition = 306;
                labelFeedback.Font = new Font("Arial", 8, FontStyle.Bold); 
                labelFeedback.ForeColor = Color.Green; 
                labelFeedback.BackColor = Color.LightYellow; 
                labelFeedback.TextAlign = ContentAlignment.MiddleCenter;
                labelFeedback.BorderStyle = BorderStyle.FixedSingle; 
                labelFeedback.Padding = new Padding(5);
                labelFeedback.Location = new Point(centerX , yPosition);
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
                int centerX = 166;
                int yPosition = 306;
                labelFeedback.Font = new Font("Arial", 10, FontStyle.Bold);
                labelFeedback.ForeColor = Color.Green; 
                labelFeedback.BackColor = Color.LightYellow;
                labelFeedback.TextAlign = ContentAlignment.MiddleCenter;
                labelFeedback.BorderStyle = BorderStyle.FixedSingle; 
                labelFeedback.Padding = new Padding(5);
                labelFeedback.Location = new Point(centerX, yPosition);
                labelFeedback.Text = "Select a word from the list.";
                return;
            }

            if (comboBoxWords.SelectedItem.ToString() == correctWords[currentImageIndex])
            {
                int centerX = 110;
                int yPosition = 306;
                labelFeedback.Font = new Font("Arial", 8, FontStyle.Bold);
                labelFeedback.ForeColor = Color.Green;
                labelFeedback.BackColor = Color.LightYellow;
                labelFeedback.TextAlign = ContentAlignment.MiddleCenter;
                labelFeedback.BorderStyle = BorderStyle.FixedSingle;
                labelFeedback.Padding = new Padding(5);
                labelFeedback.Location = new Point(centerX, yPosition);
                labelFeedback.Text = "Correct, keep going";
                currentImageIndex++;
                LoadNextImage();
            }
            else
            {
                int centerX = 110;
                int yPosition = 306;
                labelFeedback.Font = new Font("Arial", 8, FontStyle.Bold);
                labelFeedback.ForeColor = Color.Red; 
                labelFeedback.BackColor = Color.LightYellow; 
                labelFeedback.TextAlign = ContentAlignment.MiddleCenter; 
                labelFeedback.BorderStyle = BorderStyle.FixedSingle;
                labelFeedback.Padding = new Padding(5);
                labelFeedback.Location = new Point(centerX, yPosition);
                labelFeedback.Text = "Incorrect, try again.";
            }

        }

        private void UpdateUserCoins()
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Get dynamic file path
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FinalProject");
                string filePath = Path.Combine(folderPath, "UserData.xlsx");

                FileInfo fileInfo = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension?.Rows ?? 0;

                    for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                    {
                        if (worksheet.Cells[row, 1].Text == username)
                        {
                            worksheet.Cells[row, 6].Value = coins; // Update coins
                            package.Save(); // Save the file
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user coins in Excel: {ex.Message}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishGamesForm englishGamesForm = new EnglishGamesForm(username, userId, email, coins, products);
            englishGamesForm.ShowDialog();
            this.Close();
        }
    }
}