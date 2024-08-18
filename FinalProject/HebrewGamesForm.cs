using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class HebrewGamesForm : Form
    {
        private string username;
        private string userId;
        private string email;
        private int coins;
        private int products;
        private PictureBox backgroundPictureBox;

        public HebrewGamesForm(string username, string userId, string email, int coins, int products)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            this.email = email;
            this.coins = coins;
            this.products = products;

            // إعداد PictureBox للخلفية
            backgroundPictureBox = new PictureBox();
            backgroundPictureBox.Image = Properties.Resources.remote; // استخدام الصورة من الموارد
            backgroundPictureBox.Dock = DockStyle.Fill;
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // إضافة PictureBox إلى النموذج
            this.Controls.Add(backgroundPictureBox);
            this.Controls.SetChildIndex(backgroundPictureBox, 0); // وضع PictureBox في الخلفية

            // التأكد من أن عناصر التحكم الأخرى تظهر فوق الخلفية
            this.Controls.SetChildIndex(buttonLetterOrder, 1);
            this.Controls.SetChildIndex(buttonWordMatch, 1);
            this.Controls.SetChildIndex(buttonMemoryGame, 1);
            this.Controls.SetChildIndex(buttonBackToGames, 1);
        }

        private void buttonLetterOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            HebrewLetterOrderGameForm hebrewLetterOrderGameForm = new HebrewLetterOrderGameForm(username, userId, email, coins, products);
            hebrewLetterOrderGameForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // يمكن إضافة كود هنا إذا لزم الأمر
        }

        private void buttonWordMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            HebrewWordMatchGameForm HebrewWordMatchGameForm = new HebrewWordMatchGameForm(username, userId, email, coins, products);
            HebrewWordMatchGameForm.ShowDialog();
            this.Close();
        }

        private void buttonMemoryGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemoryGameForm MemoryGameForm = new MemoryGameForm(username, userId, email, coins, products);
            MemoryGameForm.ShowDialog();
            this.Close();
        }

        private void buttonBackToGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm(username, userId, email, coins, products);
            gameForm.ShowDialog();
            this.Close();
        }

        private void HebrewGamesForm_Load(object sender, EventArgs e)
        {
            // يمكن إضافة كود هنا إذا لزم الأمر
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {
            // يمكن إضافة كود هنا إذا لزم الأمر
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}