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
            this.buttonHebrewGames.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonHebrewGames.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHebrewGames.ForeColor = System.Drawing.Color.White;
            this.buttonHebrewGames.Location = new System.Drawing.Point(302, 89);
            this.buttonHebrewGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHebrewGames.Name = "buttonHebrewGames";
            this.buttonHebrewGames.Size = new System.Drawing.Size(133, 37);
            this.buttonHebrewGames.TabIndex = 0;
            this.buttonHebrewGames.Text = "משחקי עברית";
            this.buttonHebrewGames.UseVisualStyleBackColor = false;
            this.buttonHebrewGames.Click += new System.EventHandler(this.buttonHebrewGames_Click);
            // 
            // buttonMathGames
            // 
            this.buttonMathGames.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonMathGames.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMathGames.ForeColor = System.Drawing.Color.White;
            this.buttonMathGames.Location = new System.Drawing.Point(161, 119);
            this.buttonMathGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMathGames.Name = "buttonMathGames";
            this.buttonMathGames.Size = new System.Drawing.Size(133, 37);
            this.buttonMathGames.TabIndex = 1;
            this.buttonMathGames.Text = "משחקי חשבון";
            this.buttonMathGames.UseVisualStyleBackColor = false;
            this.buttonMathGames.Click += new System.EventHandler(this.buttonMathGames_Click);
            // 
            // buttonEnglishGames
            // 
            this.buttonEnglishGames.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEnglishGames.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnglishGames.ForeColor = System.Drawing.Color.White;
            this.buttonEnglishGames.Location = new System.Drawing.Point(302, 159);
            this.buttonEnglishGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnglishGames.Name = "buttonEnglishGames";
            this.buttonEnglishGames.Size = new System.Drawing.Size(133, 37);
            this.buttonEnglishGames.TabIndex = 2;
            this.buttonEnglishGames.Text = "משחקי אנגלית";
            this.buttonEnglishGames.UseVisualStyleBackColor = false;
            this.buttonEnglishGames.Click += new System.EventHandler(this.buttonEnglishGames_Click);
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.Color.Crimson;
            this.buttonBackToMain.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMain.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMain.Location = new System.Drawing.Point(140, 184);
            this.buttonBackToMain.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(154, 37);
            this.buttonBackToMain.TabIndex = 3;
            this.buttonBackToMain.Text = "חזרה למסך ראשי";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.Screenshot_2024_08_15_215119;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.buttonEnglishGames);
            this.Controls.Add(this.buttonMathGames);
            this.Controls.Add(this.buttonHebrewGames);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }
    }
}
