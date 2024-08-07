namespace FinalProject
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonHebrewGames;
        private System.Windows.Forms.Button buttonMathGames;
        private System.Windows.Forms.Button buttonEnglishGames;
        private System.Windows.Forms.Button buttonBackToMain;

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
            this.buttonHebrewGames = new System.Windows.Forms.Button();
            this.buttonMathGames = new System.Windows.Forms.Button();
            this.buttonEnglishGames = new System.Windows.Forms.Button();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHebrewGames
            // 
            this.buttonHebrewGames.Location = new System.Drawing.Point(200, 62);
            this.buttonHebrewGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHebrewGames.Name = "buttonHebrewGames";
            this.buttonHebrewGames.Size = new System.Drawing.Size(133, 37);
            this.buttonHebrewGames.TabIndex = 0;
            this.buttonHebrewGames.Text = "משחקי עברית";
            this.buttonHebrewGames.UseVisualStyleBackColor = true;
            this.buttonHebrewGames.Click += new System.EventHandler(this.buttonHebrewGames_Click);
            // 
            // buttonMathGames
            // 
            this.buttonMathGames.Location = new System.Drawing.Point(200, 123);
            this.buttonMathGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMathGames.Name = "buttonMathGames";
            this.buttonMathGames.Size = new System.Drawing.Size(133, 37);
            this.buttonMathGames.TabIndex = 1;
            this.buttonMathGames.Text = "משחקי חשבון";
            this.buttonMathGames.UseVisualStyleBackColor = true;
            this.buttonMathGames.Click += new System.EventHandler(this.buttonMathGames_Click);
            // 
            // buttonEnglishGames
            // 
            this.buttonEnglishGames.Location = new System.Drawing.Point(200, 185);
            this.buttonEnglishGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnglishGames.Name = "buttonEnglishGames";
            this.buttonEnglishGames.Size = new System.Drawing.Size(133, 37);
            this.buttonEnglishGames.TabIndex = 2;
            this.buttonEnglishGames.Text = "משחקי אנגלית";
            this.buttonEnglishGames.UseVisualStyleBackColor = true;
            this.buttonEnglishGames.Click += new System.EventHandler(this.buttonEnglishGames_Click);
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.Location = new System.Drawing.Point(200, 246);
            this.buttonBackToMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(133, 37);
            this.buttonBackToMain.TabIndex = 3;
            this.buttonBackToMain.Text = "חזרה למסך ראשי";
            this.buttonBackToMain.UseVisualStyleBackColor = true;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.buttonEnglishGames);
            this.Controls.Add(this.buttonMathGames);
            this.Controls.Add(this.buttonHebrewGames);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "GameForm";
    
            this.ResumeLayout(false);

        }
    }
}
