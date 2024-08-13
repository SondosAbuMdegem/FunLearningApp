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
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(149, 37);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(210, 31);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "English Games";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLetterOrder
            // 
            this.buttonLetterOrder.Location = new System.Drawing.Point(173, 98);
            this.buttonLetterOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLetterOrder.Name = "buttonLetterOrder";
            this.buttonLetterOrder.Size = new System.Drawing.Size(160, 37);
            this.buttonLetterOrder.TabIndex = 1;
            this.buttonLetterOrder.Text = "כתיבת אותיות לפי סדר";
            this.buttonLetterOrder.UseVisualStyleBackColor = true;
            this.buttonLetterOrder.Click += new System.EventHandler(this.buttonLetterOrder_Click);
            // 
            // buttonLetterMatch
            // 
            this.buttonLetterMatch.Location = new System.Drawing.Point(173, 160);
            this.buttonLetterMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLetterMatch.Name = "buttonLetterMatch";
            this.buttonLetterMatch.Size = new System.Drawing.Size(160, 37);
            this.buttonLetterMatch.TabIndex = 2;
            this.buttonLetterMatch.Text = "התאמת מילה לתמונה";
            this.buttonLetterMatch.UseVisualStyleBackColor = true;
            this.buttonLetterMatch.Click += new System.EventHandler(this.buttonLetterMatch_Click);
            // 
            // buttonMemoryGame
            // 
            this.buttonMemoryGame.Location = new System.Drawing.Point(173, 222);
            this.buttonMemoryGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMemoryGame.Name = "buttonMemoryGame";
            this.buttonMemoryGame.Size = new System.Drawing.Size(160, 37);
            this.buttonMemoryGame.TabIndex = 3;
            this.buttonMemoryGame.Text = "משחק זיכרון";
            this.buttonMemoryGame.UseVisualStyleBackColor = true;
            this.buttonMemoryGame.Click += new System.EventHandler(this.buttonMemoryGame_Click);
            // 
            // buttonBackToGames
            // 
            this.buttonBackToGames.Location = new System.Drawing.Point(173, 283);
            this.buttonBackToGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackToGames.Name = "buttonBackToGames";
            this.buttonBackToGames.Size = new System.Drawing.Size(160, 37);
            this.buttonBackToGames.TabIndex = 4;
            this.buttonBackToGames.Text = "חזרה למסך משחקים";
            this.buttonBackToGames.UseVisualStyleBackColor = true;
            this.buttonBackToGames.Click += new System.EventHandler(this.buttonBackToGames_Click);
            // 
            // EnglishGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 392);
            this.Controls.Add(this.buttonBackToGames);
            this.Controls.Add(this.buttonMemoryGame);
            this.Controls.Add(this.buttonLetterMatch);
            this.Controls.Add(this.buttonLetterOrder);
            this.Controls.Add(this.labelCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnglishGamesForm";
            this.Text = "English Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
