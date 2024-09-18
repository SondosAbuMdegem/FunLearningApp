using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace FinalProject
{
    public partial class RegisterForm : Form
    {
        private string excelFilePath;

        public RegisterForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(RegisterForm_Load);
            excelFilePath = GetExcelFilePath(); // Initialize the file path dynamically
        }

        // Function to determine the dynamic file path
        private string GetExcelFilePath()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Set the file to be in a more accessible location for testing
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = Path.Combine(documentsPath, "FinalProject");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "UserData.xlsx");

            // Create Excel file if it doesn't exist
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


        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string id = textBoxID.Text;
            string email = textBoxEmail.Text;
            string gender = radioButtonMale.Checked ? "Male" : "Female";

            string usernamePattern = @"^(?=.*[A-Za-z])[A-Za-z0-9]{6,8}$";
            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,10}$";

            if (!Regex.IsMatch(username, usernamePattern) || username.Count(char.IsDigit) > 2)
            {
                labelError.ForeColor = System.Drawing.Color.Red;
                labelError.Text = "שם משתמש לא תקין. צריך להכיל בין 6 ל-8 תווים, לכל היותר 2 ספרות.";
                return;
            }

            if (!Regex.IsMatch(password, passwordPattern))
            {
                labelError.ForeColor = System.Drawing.Color.Red;
                labelError.Text = "סיסמה לא תקינה. צריך להכיל בין 8 ל-10 תווים, לפחות אות אחת, סיפרה אחת ותו מיוחד אחד.";
                return;
            }

            if (!IsValidID(id))
            {
                labelError.ForeColor = System.Drawing.Color.Red;
                labelError.Text = "מספר ת\"ז לא תקין. צריך להכיל בדיוק 9 ספרות.";
                return;
            }

            if (!IsValidEmail(email))
            {
                labelError.ForeColor = System.Drawing.Color.Red;
                labelError.Text = "כתובת מייל לא תקינה.";
                return;
            }

            if (!IsUniqueUsername(username))
            {
                labelError.ForeColor = System.Drawing.Color.Red;
                labelError.Text = "שם המשתמש כבר קיים במערכת.";
                return;
            }

            if (!IsUniqueID(id))
            {
                labelError.ForeColor = System.Drawing.Color.Red;
                labelError.Text = "מספר ת\"ז כבר קיים במערכת.";
                return;
            }

            SaveToExcel(username, password, id, email, gender);
            labelError.ForeColor = System.Drawing.Color.Green;
            labelError.Text = "הרשמה בוצעה בהצלחה!";

            // Open LoginForm
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidID(string id)
        {
            return Regex.IsMatch(id, @"^\d{9}$");
        }

        private bool IsUniqueUsername(string username)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo fileInfo = new FileInfo(excelFilePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsUniqueID(string id)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo fileInfo = new FileInfo(excelFilePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) // Start from 2 to skip headers
                {
                    if (worksheet.Cells[row, 3].Text == id)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void SaveToExcel(string username, string password, string id, string email, string gender)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(excelFilePath);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet;
                    if (package.Workbook.Worksheets.Count == 0)
                    {
                        worksheet = package.Workbook.Worksheets.Add("Users");
                        worksheet.Cells[1, 1].Value = "Username";
                        worksheet.Cells[1, 2].Value = "Password";
                        worksheet.Cells[1, 3].Value = "ID";
                        worksheet.Cells[1, 4].Value = "Email";
                        worksheet.Cells[1, 5].Value = "Gender";
                        worksheet.Cells[1, 6].Value = "Coins";
                        worksheet.Cells[1, 7].Value = "Products";
                    }
                    else
                    {
                        worksheet = package.Workbook.Worksheets[0];
                    }

                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    worksheet.Cells[rowCount + 1, 1].Value = username;
                    worksheet.Cells[rowCount + 1, 2].Value = password;
                    worksheet.Cells[rowCount + 1, 3].Value = id;
                    worksheet.Cells[rowCount + 1, 4].Value = email;
                    worksheet.Cells[rowCount + 1, 5].Value = gender;
                    worksheet.Cells[rowCount + 1, 6].Value = 0;
                    worksheet.Cells[rowCount + 1, 7].Value = 0;

                    // Save the Excel file
                    package.Save();

                    // Verify if file has been saved
                    if (fileInfo.Exists)
                    {
                        MessageBox.Show("File exists at: " + fileInfo.FullName);
                    }
                    else
                    {
                        MessageBox.Show("File does not exist!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to Excel: {ex.Message}");
            }
        }
    }
}
