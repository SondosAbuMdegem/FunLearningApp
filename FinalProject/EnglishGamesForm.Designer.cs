namespace FinalProject
{
    partial class EnglishGamesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonLetterOrder;
        private System.Windows.Forms.Button buttonLetterMatch;
        private System.Windows.Forms.Button buttonMemoryGame;
        private System.Windows.Forms.Button buttonBackToGames;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonLetterOrder = new System.Windows.Forms.Button();
            this.buttonLetterMatch = new System.Windows.Forms.Button();
            this.buttonMemoryGame = new System.Windows.Forms.Button();
            this.buttonBackToGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.Color.RosyBrown;
            this.labelCategory.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(173, 101);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(222, 56);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "English Games";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLetterOrder
            // 
            this.buttonLetterOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLetterOrder.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetterOrder.ForeColor = System.Drawing.Color.White;
            this.buttonLetterOrder.Location = new System.Drawing.Point(188, 224);
            this.buttonLetterOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLetterOrder.Name = "buttonLetterOrder";
            this.buttonLetterOrder.Size = new System.Drawing.Size(191, 44);
            this.buttonLetterOrder.TabIndex = 2;
            this.buttonLetterOrder.Text = "כתיבת אותיות לפי סדר";
            this.buttonLetterOrder.UseVisualStyleBackColor = false;
            this.buttonLetterOrder.Click += new System.EventHandler(this.buttonLetterOrder_Click);
            // 
            // buttonLetterMatch
            // 
            this.buttonLetterMatch.BackColor = System.Drawing.Color.DeepPink;
            this.buttonLetterMatch.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetterMatch.ForeColor = System.Drawing.Color.White;
            this.buttonLetterMatch.Location = new System.Drawing.Point(188, 172);
            this.buttonLetterMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLetterMatch.Name = "buttonLetterMatch";
            this.buttonLetterMatch.Size = new System.Drawing.Size(191, 44);
            this.buttonLetterMatch.TabIndex = 2;
            this.buttonLetterMatch.Text = "התאמת מילה לתמונה";
            this.buttonLetterMatch.UseVisualStyleBackColor = false;
            this.buttonLetterMatch.Click += new System.EventHandler(this.buttonLetterMatch_Click);
            // 
            // buttonMemoryGame
            // 
            this.buttonMemoryGame.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonMemoryGame.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryGame.ForeColor = System.Drawing.Color.White;
            this.buttonMemoryGame.Location = new System.Drawing.Point(188, 276);
            this.buttonMemoryGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMemoryGame.Name = "buttonMemoryGame";
            this.buttonMemoryGame.Size = new System.Drawing.Size(191, 44);
            this.buttonMemoryGame.TabIndex = 3;
            this.buttonMemoryGame.Text = "משחק זיכרון";
            this.buttonMemoryGame.UseVisualStyleBackColor = false;
            this.buttonMemoryGame.Click += new System.EventHandler(this.buttonMemoryGame_Click);
            // 
            // buttonBackToGames
            // 
            this.buttonBackToGames.BackColor = System.Drawing.Color.Crimson;
            this.buttonBackToGames.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToGames.ForeColor = System.Drawing.Color.White;
            this.buttonBackToGames.Location = new System.Drawing.Point(188, 335);
            this.buttonBackToGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackToGames.Name = "buttonBackToGames";
            this.buttonBackToGames.Size = new System.Drawing.Size(191, 44);
            this.buttonBackToGames.TabIndex = 4;
            this.buttonBackToGames.Text = "חזרה למסך משחקים";
            this.buttonBackToGames.UseVisualStyleBackColor = false;
            this.buttonBackToGames.Click += new System.EventHandler(this.buttonBackToGames_Click);
            // 
            // EnglishGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.Screenshot_2024_08_14_220010;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(565, 392);
            this.Controls.Add(this.buttonBackToGames);
            this.Controls.Add(this.buttonMemoryGame);
            this.Controls.Add(this.buttonLetterMatch);
            this.Controls.Add(this.buttonLetterOrder);
            this.Controls.Add(this.labelCategory);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnglishGamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Games";
            this.ResumeLayout(false);

        }
    }
}
