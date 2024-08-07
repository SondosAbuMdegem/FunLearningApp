namespace FinalProject
{
    partial class EnglishWordMatchGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxWords;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelFeedback;
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(200, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(267, 185);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Items.AddRange(new object[] {
            "dog",
            "cat",
            "red",
            "five",
            "tree"});
            this.comboBoxWords.Location = new System.Drawing.Point(200, 271);
            this.comboBoxWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(265, 24);
            this.comboBoxWords.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(200, 335);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(267, 37);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "בדוק";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(200, 382);
            this.labelFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 16);
            this.labelFeedback.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(200, 418);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(267, 37);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EnglishWordMatchGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 492);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EnglishWordMatchGameForm";
            this.Text = "Match the Word to the Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
