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
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.Honeydew;
            this.labelCategory.Location = new System.Drawing.Point(677, 54);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(237, 42);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "משחקי עברית";
            // 
            // buttonLetterOrder
            // 
            this.buttonLetterOrder.BackColor = System.Drawing.Color.Orange;
            this.buttonLetterOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLetterOrder.ForeColor = System.Drawing.Color.White;
            this.buttonLetterOrder.Location = new System.Drawing.Point(114, 226);
            this.buttonLetterOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLetterOrder.Name = "buttonLetterOrder";
            this.buttonLetterOrder.Size = new System.Drawing.Size(247, 55);
            this.buttonLetterOrder.TabIndex = 1;
            this.buttonLetterOrder.Text = "כתיבת אותיות לפי סדר";
            this.buttonLetterOrder.UseVisualStyleBackColor = false;
            this.buttonLetterOrder.Click += new System.EventHandler(this.buttonLetterOrder_Click);
            // 
            // buttonWordMatch
            // 
            this.buttonWordMatch.BackColor = System.Drawing.Color.DarkRed;
            this.buttonWordMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonWordMatch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWordMatch.Location = new System.Drawing.Point(114, 351);
            this.buttonWordMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWordMatch.Name = "buttonWordMatch";
            this.buttonWordMatch.Size = new System.Drawing.Size(250, 55);
            this.buttonWordMatch.TabIndex = 2;
            this.buttonWordMatch.Text = "התאמת מילה לתמונה";
            this.buttonWordMatch.UseVisualStyleBackColor = false;
            this.buttonWordMatch.Click += new System.EventHandler(this.buttonWordMatch_Click);
            // 
            // buttonMemoryGame
            // 
            this.buttonMemoryGame.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonMemoryGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMemoryGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMemoryGame.Location = new System.Drawing.Point(114, 124);
            this.buttonMemoryGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMemoryGame.Name = "buttonMemoryGame";
            this.buttonMemoryGame.Size = new System.Drawing.Size(247, 51);
            this.buttonMemoryGame.TabIndex = 3;
            this.buttonMemoryGame.Text = "משחק זיכרון";
            this.buttonMemoryGame.UseVisualStyleBackColor = false;
            this.buttonMemoryGame.Click += new System.EventHandler(this.buttonMemoryGame_Click);
            // 
            // buttonBackToGames
            // 
            this.buttonBackToGames.BackColor = System.Drawing.Color.Purple;
            this.buttonBackToGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBackToGames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackToGames.Location = new System.Drawing.Point(140, 444);
            this.buttonBackToGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackToGames.Name = "buttonBackToGames";
            this.buttonBackToGames.Size = new System.Drawing.Size(207, 37);
            this.buttonBackToGames.TabIndex = 4;
            this.buttonBackToGames.Text = "חזרה למסך משחקים";
            this.buttonBackToGames.UseVisualStyleBackColor = false;
            this.buttonBackToGames.Click += new System.EventHandler(this.buttonBackToGames_Click);
            // 
            // HebrewGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.hanukkah_decoration_144627_47629;
            this.ClientSize = new System.Drawing.Size(996, 541);
            this.Controls.Add(this.buttonBackToGames);
            this.Controls.Add(this.buttonMemoryGame);
            this.Controls.Add(this.buttonWordMatch);
            this.Controls.Add(this.buttonLetterOrder);
            this.Controls.Add(this.labelCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HebrewGamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "משחקי עברית";
            this.ResumeLayout(false);

        }
    }
}
