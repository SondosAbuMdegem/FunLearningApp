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
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(167, 37);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(173, 31);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "משחקי חשבון";
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(173, 123);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(160, 37);
            this.buttonAddition.TabIndex = 1;
            this.buttonAddition.Text = "חיבור מספרים";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(173, 185);
            this.buttonSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(160, 37);
            this.buttonSubtraction.TabIndex = 2;
            this.buttonSubtraction.Text = "חיסור מספרים";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.buttonSubtraction_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(173, 246);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(160, 37);
            this.buttonMultiplication.TabIndex = 3;
            this.buttonMultiplication.Text = "כפל של מספרים קטנים";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonBackToGames
            // 
            this.buttonBackToGames.Location = new System.Drawing.Point(173, 308);
            this.buttonBackToGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackToGames.Name = "buttonBackToGames";
            this.buttonBackToGames.Size = new System.Drawing.Size(160, 37);
            this.buttonBackToGames.TabIndex = 4;
            this.buttonBackToGames.Text = "חזרה למסך משחקים";
            this.buttonBackToGames.UseVisualStyleBackColor = true;
            this.buttonBackToGames.Click += new System.EventHandler(this.buttonBackToGames_Click);
            // 
            // MathGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.buttonBackToGames);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.labelCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MathGamesForm";
            this.Text = "משחקי חשבון";
            this.Load += new System.EventHandler(this.MathGamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
