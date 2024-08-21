using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("התחברת בהצלחה!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Retrieve the current logged-in user's details
                string userId = GetUserId(username);
                string email = GetUserEmail(username);
                int coins = GetUserCoins(username);
                int products = GetUserProducts(username);

                // Open MainForm
                this.Hide();
                MainForm mainForm = new MainForm(username, userId, email, coins, products);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                labelError.Text = "שם משתמש או סיסמה לא נכונים.";
            }
        }

        private string GetUserId(string username)
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
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        return worksheet.Cells[row, 3].Text; // User ID is in the 3rd column
                    }
                }
            }
            return string.Empty;
        }

        private string GetUserEmail(string username)
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
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        return worksheet.Cells[row, 4].Text; // Email is in the 4th column
                    }
                }
            }
            return string.Empty;
        }

        private int GetUserCoins(string username)
        {
            // Implement logic to retrieve user coins from the Excel file
            // Assuming coins are in the 6th column for example purposes
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\97254\source\repos\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        int.TryParse(worksheet.Cells[row, 6].Text, out int coins);
                        return coins; // Coins are in the 6th column
                    }
                }
            }
            return 0;
        }

        private int GetUserProducts(string username)
        {
            // Implement logic to retrieve user products from the Excel file
            // Assuming products are in the 7th column for example purposes
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\97254\source\repos\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        int.TryParse(worksheet.Cells[row, 7].Text, out int products);
                        return products; // Products are in the 7th column
                    }
                }
            }
            return 0;
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private bool ValidateUser(string username, string password)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\97254\source\repos\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    return false;
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    string storedUsername = worksheet.Cells[row, 1].Text;
                    string storedPassword = worksheet.Cells[row, 2].Text;

                    if (username == storedUsername && password == storedPassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
