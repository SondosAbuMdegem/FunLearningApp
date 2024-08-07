namespace FinalProject
{
    partial class HebrewGamesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonLetterOrder;
        private System.Windows.Forms.Button buttonWordMatch;
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
            this.buttonWordMatch = new System.Windows.Forms.Button();
            this.buttonMemoryGame = new System.Windows.Forms.Button();
            this.buttonBackToGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(183, 27);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(176, 31);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "משחקי עברית";
            // 
            // buttonLetterOrder
            // 
            this.buttonLetterOrder.Location = new System.Drawing.Point(189, 106);
            this.buttonLetterOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLetterOrder.Name = "buttonLetterOrder";
            this.buttonLetterOrder.Size = new System.Drawing.Size(158, 37);
            this.buttonLetterOrder.TabIndex = 1;
            this.buttonLetterOrder.Text = "כתיבת אותיות לפי סדר";
            this.buttonLetterOrder.UseVisualStyleBackColor = true;
            this.buttonLetterOrder.Click += new System.EventHandler(this.buttonLetterOrder_Click);
            // 
            // buttonWordMatch
            // 
            this.buttonWordMatch.Location = new System.Drawing.Point(189, 167);
            this.buttonWordMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWordMatch.Name = "buttonWordMatch";
            this.buttonWordMatch.Size = new System.Drawing.Size(158, 37);
            this.buttonWordMatch.TabIndex = 2;
            this.buttonWordMatch.Text = "התאמת מילה לתמונה";
            this.buttonWordMatch.UseVisualStyleBackColor = true;
            this.buttonWordMatch.Click += new System.EventHandler(this.buttonWordMatch_Click);
            // 
            // buttonMemoryGame
            // 
            this.buttonMemoryGame.Location = new System.Drawing.Point(189, 229);
            this.buttonMemoryGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMemoryGame.Name = "buttonMemoryGame";
            this.buttonMemoryGame.Size = new System.Drawing.Size(158, 37);
            this.buttonMemoryGame.TabIndex = 3;
            this.buttonMemoryGame.Text = "משחק זיכרון";
            this.buttonMemoryGame.UseVisualStyleBackColor = true;
            this.buttonMemoryGame.Click += new System.EventHandler(this.buttonMemoryGame_Click);
            // 
            // buttonBackToGames
            // 
            this.buttonBackToGames.Location = new System.Drawing.Point(189, 290);
            this.buttonBackToGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackToGames.Name = "buttonBackToGames";
            this.buttonBackToGames.Size = new System.Drawing.Size(158, 37);
            this.buttonBackToGames.TabIndex = 4;
            this.buttonBackToGames.Text = "חזרה למסך משחקים";
            this.buttonBackToGames.UseVisualStyleBackColor = true;
            this.buttonBackToGames.Click += new System.EventHandler(this.buttonBackToGames_Click);
            // 
            // HebrewGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.buttonBackToGames);
            this.Controls.Add(this.buttonMemoryGame);
            this.Controls.Add(this.buttonWordMatch);
            this.Controls.Add(this.buttonLetterOrder);
            this.Controls.Add(this.labelCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HebrewGamesForm";
            this.Text = "משחקי עברית";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
