using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MemoryGameForm : Form
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

        public MemoryGameForm(string username, string userId, string email, int coins, int products)
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
                "ab.jpg", "as.jpg",
                "db.jpg", "hs.jpg",
                "mb.jpg", "ss.jpg",
                "tb.jpg", "us.jpg",
                "ab.jpg", "as.jpg",
                "db.jpg", "hs.jpg",
                "mb.jpg", "ss.jpg",
                "tb.jpg", "us.jpg"
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

            // Check if the first two characters of the tags are the same
            if (GetImagePrefix(firstClicked.Tag.ToString()) == GetImagePrefix(secondClicked.Tag.ToString()))
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
                MessageBox.Show("ניצחת! קיבלת 10 מטבעות");
                coins += 10;
                UpdateUserCoins();
            }
        }

        private string GetImagePrefix(string imageName)
        {
            return imageName.Substring(0, 2); // Assuming the prefix is the first two characters
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

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HebrewGamesForm hebrewGamesForm = new HebrewGamesForm(username, userId, email, coins, products);
            hebrewGamesForm.ShowDialog();
            this.Close();
        }
    }
}
