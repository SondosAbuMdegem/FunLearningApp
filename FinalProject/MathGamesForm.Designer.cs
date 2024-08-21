namespace FinalProject
{
    partial class MathGamesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonMultiplication;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathGamesForm));
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonBackToGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelCategory.Location = new System.Drawing.Point(151, 28);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(231, 48);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "משחקי חשבון";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCategory.Click += new System.EventHandler(this.labelCategory_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAddition.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddition.Location = new System.Drawing.Point(170, 100);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(200, 50);
            this.buttonAddition.TabIndex = 1;
            this.buttonAddition.Text = "חיבור מספרים";
            this.buttonAddition.UseVisualStyleBackColor = false;
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSubtraction.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSubtraction.Location = new System.Drawing.Point(170, 170);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(200, 50);
            this.buttonSubtraction.TabIndex = 2;
            this.buttonSubtraction.Text = "חיסור מספרים";
            this.buttonSubtraction.UseVisualStyleBackColor = false;
            this.buttonSubtraction.Click += new System.EventHandler(this.buttonSubtraction_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMultiplication.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplication.Location = new System.Drawing.Point(170, 240);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(200, 50);
            this.buttonMultiplication.TabIndex = 3;
            this.buttonMultiplication.Text = "כפל מספרים";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonBackToGames
            // 
            this.buttonBackToGames.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonBackToGames.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.buttonBackToGames.Location = new System.Drawing.Point(170, 310);
            this.buttonBackToGames.Name = "buttonBackToGames";
            this.buttonBackToGames.Size = new System.Drawing.Size(200, 50);
            this.buttonBackToGames.TabIndex = 4;
            this.buttonBackToGames.Text = "חזרה למשחקים";
            this.buttonBackToGames.UseVisualStyleBackColor = false;
            this.buttonBackToGames.Click += new System.EventHandler(this.buttonBackToGames_Click);
            // 
            // MathGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 419);
            this.Controls.Add(this.buttonBackToGames);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.labelCategory);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MathGamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "משחקי חשבון";
            this.Load += new System.EventHandler(this.MathGamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
