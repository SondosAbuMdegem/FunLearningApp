using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MultiplicationGameForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private Random random = new Random();

        public MultiplicationGameForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            GenerateNewQuestion();
        }

        private void GenerateNewQuestion()
        {
            int num1 = random.Next(1, 6);
            int num2 = random.Next(1, 6);
            labelQuestion.Text = $"{num1} x {num2} = ?";
            labelQuestion.Tag = num1 * num2; // Store the correct answer in the tag
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int correctAnswer = (int)labelQuestion.Tag;
            if (int.TryParse(textBoxAnswer.Text, out int userAnswer) && userAnswer == correctAnswer)
            {
                MessageBox.Show("תשובה נכונה קיבלת 1 קוינז");
                coins += 1;
                UpdateUserCoins();
                GenerateNewQuestion();
            }
            else
            {
                MessageBox.Show("תשובה לא נכונה נסה שנית");
            }
            textBoxAnswer.Clear();
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
            MathGamesForm mathGamesForm = new MathGamesForm(username, userId, email, coins, products);
            mathGamesForm.ShowDialog();
            this.Close();
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
