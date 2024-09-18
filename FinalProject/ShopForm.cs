using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace FinalProject
{
    public partial class ShopForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private string excelFilePath;

        public ShopForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            UpdateCoinsLabel();
            SetFontSize();
            excelFilePath = GetExcelFilePath(); // Initialize the file path dynamically
        }

        private void UpdateCoinsLabel()
        {
            labelCoins.Text = $"מטבעות זמינים: {coins}";
        }

        private void SetFontSize()
        {
            listBoxStickers.Font = new Font(listBoxStickers.Font.FontFamily, 14);
            listBoxToys.Font = new Font(listBoxToys.Font.FontFamily, 14);
            listBoxPencilCases.Font = new Font(listBoxPencilCases.Font.FontFamily, 14);
            tabControlCategories.Font = new Font(tabControlCategories.Font.FontFamily, 14);
        }

        private string GetExcelFilePath()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, "FinalProject");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "UserData.xlsx");

            if (!File.Exists(filePath))
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Users");
                    worksheet.Cells[1, 1].Value = "Username";
                    worksheet.Cells[1, 2].Value = "Password";
                    worksheet.Cells[1, 3].Value = "ID";
                    worksheet.Cells[1, 4].Value = "Email";
                    worksheet.Cells[1, 5].Value = "Gender";
                    worksheet.Cells[1, 6].Value = "Coins";
                    worksheet.Cells[1, 7].Value = "Products";
                    package.SaveAs(new FileInfo(filePath));
                }
            }

            return filePath;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (tabControlCategories.SelectedTab == tabPageStickers)
            {
                BuyItem(listBoxStickers.SelectedItem?.ToString());
            }
            else if (tabControlCategories.SelectedTab == tabPageToys)
            {
                BuyItem(listBoxToys.SelectedItem?.ToString());
            }
            else if (tabControlCategories.SelectedTab == tabPagePencilCases)
            {
                BuyItem(listBoxPencilCases.SelectedItem?.ToString());
            }
        }

        private void BuyItem(string item)
        {
            if (string.IsNullOrEmpty(item)) return;

            int price = int.Parse(item.Split('-')[1].Replace("מטבעות", "").Trim());
            if (coins >= price)
            {
                coins -= price;
                products++;
                UpdateCoinsLabel();
                MessageBox.Show("הרכישה הצליחה!");
                UpdateUserCoins();
            }
            else
            {
                MessageBox.Show("אין לך מספיק מטבעות.");
            }
        }

        private void UpdateUserCoins()
        {
            try
            {
                FileInfo fileInfo = new FileInfo(excelFilePath);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension?.Rows ?? 0;

                    for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                    {
                        if (worksheet.Cells[row, 1].Text == username)
                        {
                            worksheet.Cells[row, 6].Value = coins; // Coins in 6th column
                            worksheet.Cells[row, 7].Value = products; // Products in 7th column
                            package.Save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user data: {ex.Message}");
            }
        }

        private void listBoxStickers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStickers.SelectedItem != null)
            {
                string selectedItem = listBoxStickers.SelectedItem.ToString();
                string imageName = "";

                if (selectedItem.Contains("אדום"))
                    imageName = "stred";
                else if (selectedItem.Contains("כחול"))
                    imageName = "stblue";
                else if (selectedItem.Contains("ירוק"))
                    imageName = "stgreen";
                else if (selectedItem.Contains("צבעוניות"))
                    imageName = "stcolored";

                DisplayProductImage(imageName);
            }
        }

        private void listBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxToys.SelectedItem != null)
            {
                string selectedItem = listBoxToys.SelectedItem.ToString();
                string imageName = "";

                if (selectedItem.Contains("בובה עדינה"))
                    imageName = "pr1";
                else if (selectedItem.Contains("רכב קיה"))
                    imageName = "pr2";
                else if (selectedItem.Contains("רכב לימוזינה"))
                    imageName = "pr3";
                else if (selectedItem.Contains("מזוודת סליים"))
                    imageName = "pr4";

                DisplayProductImage(imageName);
            }
        }

        private void listBoxPencilCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPencilCases.SelectedItem != null)
            {
                string selectedItem = listBoxPencilCases.SelectedItem.ToString();
                string imageName = "";

                if (selectedItem.Contains("ורוד"))
                    imageName = "kl1";
                else if (selectedItem.Contains("כחול"))
                    imageName = "kl2";
                else if (selectedItem.Contains("ורוד כדורגל"))
                    imageName = "kl3";
                else if (selectedItem.Contains("מגרש כדורגל"))
                    imageName = "kl4";

                DisplayProductImage(imageName);
            }
        }

        private void DisplayProductImage(string productName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(basePath, "Images", $"{productName}.jpg");

            if (File.Exists(imagePath))
            {
                pictureBoxProduct.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxProduct.Image = null;
            }
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            tabControlCategories.RightToLeft = RightToLeft.Yes;
            tabControlCategories.RightToLeftLayout = true;
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(username, userId, email, coins, products);
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
