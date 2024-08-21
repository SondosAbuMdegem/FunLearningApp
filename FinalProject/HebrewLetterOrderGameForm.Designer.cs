namespace FinalProject
{
    partial class HebrewLetterOrderGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;

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
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrompt.Location = new System.Drawing.Point(81, 24);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(361, 31);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "תרשום את האותיות לפי הסדר";
            this.labelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxInput.Location = new System.Drawing.Point(131, 136);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(245, 22);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(196, 136);
            this.labelFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 16);
            this.labelFeedback.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSubmit.Location = new System.Drawing.Point(366, 210);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(133, 37);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "בדוק";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Location = new System.Drawing.Point(13, 210);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 37);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // HebrewLetterOrderGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::FinalProject.Properties.Resources.dreidels_confetti_candies_23_2147968771;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelPrompt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HebrewLetterOrderGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "כתיבת אותיות לפי סדר";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
