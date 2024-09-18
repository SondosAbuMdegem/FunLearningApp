using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace FinalProject
{
    public partial class HebrewWordMatchGameForm : Form
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
            "כלב", "חתול", "אדום", "חמש", "עץ"
        };

        public HebrewWordMatchGameForm(string username, string userId, string email, int coins, int products)
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
                labelFeedback.Text = "";
            }
            else
            {
                labelFeedback.Text = "ניצחת! קיבלת 10 מטבעות";
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
                labelFeedback.Text = "בחר מילה מהרשימה.";
                return;
            }

            if (comboBoxWords.SelectedItem.ToString() == correctWords[currentImageIndex])
            {
                currentImageIndex++;
                LoadNextImage();
            }
            else
            {
                labelFeedback.Text = "לא נכון, נסה שוב";
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
            HebrewGamesForm hebrewGamesForm = new HebrewGamesForm(username, userId, email, coins, products);
            hebrewGamesForm.ShowDialog();
            this.Close();
        }

        private void HebrewWordMatchGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
