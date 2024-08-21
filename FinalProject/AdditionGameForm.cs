using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdditionGameForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private Random random = new Random();

        public AdditionGameForm(string username, string userId, string email, int coins, int products)
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
            int num1 = random.Next(1, 51);
            int num2 = random.Next(1, 51);
            labelQuestion.Text = $"{num1} + {num2} = ?";
            labelQuestion.Tag = num1 + num2; 
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
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\Users\m1571\OneDrive\Desktop\FinalProject\UserData.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension?.Rows ?? 0;

                for (int row = 2; row <= rowCount; row++) 
                {
                    if (worksheet.Cells[row, 1].Text == username)
                    {
                        worksheet.Cells[row, 6].Value = coins; 
                        package.Save();
                        break;
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathGamesForm mathGamesForm = new MathGamesForm(username, userId, email, coins, products);
            mathGamesForm.ShowDialog();
            this.Close();
        }
    }
}
