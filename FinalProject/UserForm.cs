using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UserForm : Form
    {
        private string userId;
        private string email;
        private int coins;
        private int products;
        private string username;

        public UserForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            this.username = username;
            try
            {
                LoadUserData(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
        }

        private void LoadUserData(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\97254\source\repos\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    string storedUserId = worksheet.Cells[row, 3].Text;
                    if (storedUserId == userId)
                    {
                        textBoxUsername.Text = worksheet.Cells[row, 1].Text;
                        labelID.Text = $"מספר ת\"ז: {userId}";
                        labelEmail.Text = $"כתובת מייל: {email}";
                        labelCoins.Text = $"כמות מטבעות: {worksheet.Cells[row, 6].Text}";
                        labelProducts.Text = $"מוצרים שנקנו: {products}";
                        break;
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxUsername.Text;
            string newPassword = textBoxPassword.Text;

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                labelError.Text = "שם משתמש וסיסמה לא יכולים להיות ריקים.";
                return;
            }

            if (newUsername.Length < 6 || newUsername.Length > 8 || newUsername.Count(char.IsDigit) > 2)
            {
                labelError.Text = "שם משתמש לא תקין. צריך להכיל בין 6 ל-8 תווים, לכל היותר 2 ספרות.";
                return;
            }

            if (newPassword.Length < 8 || newPassword.Length > 10 || !newPassword.Any(char.IsLetter) || !newPassword.Any(char.IsDigit) || !newPassword.Any(c => "!@#$%^&*".Contains(c)))
            {
                labelError.Text = "סיסמה לא תקינה. צריך להכיל בין 8 ל-10 תווים, לפחות אות אחת, סיפרה אחת ותו מיוחד אחד.";
                return;
            }

            try
            {
                UpdateUserData(newUsername, newPassword);
                labelError.ForeColor = System.Drawing.Color.Green;
                labelError.Text = "פרטים עודכנו בהצלחה!";
                MessageBox.Show("פרטים עודכנו בהצלחה!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserData(string newUsername, string newPassword)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\97254\source\repos\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    string storedUserId = worksheet.Cells[row, 3].Text;
                    if (storedUserId == userId)
                    {
                        worksheet.Cells[row, 1].Value = newUsername;
                        worksheet.Cells[row, 2].Value = newPassword;
                        package.Save();
                        break;
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(username, userId, email, coins, products);
            mainForm.ShowDialog();
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }
    }
}
