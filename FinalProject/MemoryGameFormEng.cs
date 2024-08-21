using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MemoryGameFormEng : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private List<Button> buttons;
        private List<string> images;
        private Button firstClicked, secondClicked;
        private Timer timer = new Timer { Interval = 750 };

        public MemoryGameFormEng(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new List<Button>();
            images = new List<string>
            {
                "a1.jpg", "a.jpg",
                "b1.jpg", "b.jpg",
                "c1.jpg", "c.jpg",
                "d1.jpg", "d.jpg",
                "e1.jpg", "e.jpg",
                "f1.jpg", "f.jpg",
                "g1.jpg", "g.jpg",
                "h1.jpg", "h.jpg"
            };

            images = images.OrderBy(a => Guid.NewGuid()).ToList(); // Shuffle images

            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button button = new Button
                    {
                        Dock = DockStyle.Fill,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = images[index++],
                        BackColor = Color.Gray
                    };
                    button.Click += Button_Click;
                    buttons.Add(button);
                    tableLayoutPanel.Controls.Add(button, j, i);
                }
            }

            timer.Tick += Timer_Tick;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            if (clickedButton.BackgroundImage != null)
                return;

            clickedButton.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", clickedButton.Tag.ToString()));

            if (firstClicked == null)
            {
                firstClicked = clickedButton;
                return;
            }

            secondClicked = clickedButton;

            if (IsMatch(firstClicked.Tag.ToString(), secondClicked.Tag.ToString()))
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer.Start();
            }

            if (buttons.All(b => b.BackgroundImage != null))
            {
                MessageBox.Show("You won! You've earned 10 coins.");
                coins += 10;
                UpdateUserCoins();
            }
        }

        private bool IsMatch(string firstTag, string secondTag)
        {
            string firstLetter = Path.GetFileNameWithoutExtension(firstTag);
            string secondLetter = Path.GetFileNameWithoutExtension(secondTag);

            return (firstLetter.Length == 1 && secondLetter.Length == 2 && firstLetter[0] == secondLetter[0]) ||
                   (firstLetter.Length == 2 && secondLetter.Length == 1 && firstLetter[0] == secondLetter[0]);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            firstClicked.BackgroundImage = null;
            secondClicked.BackgroundImage = null;
            firstClicked = null;
            secondClicked = null;
        }

        private void UpdateUserCoins()
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
                        worksheet.Cells[row, 6].Value = coins; // Assuming the coins are in the 6th column
                        package.Save();
                        break;
                    }
                }
            }
        }

        private void MemoryGameFormEng_Load(object sender, EventArgs e)
        {

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
