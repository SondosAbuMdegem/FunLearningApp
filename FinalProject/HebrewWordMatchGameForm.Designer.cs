namespace FinalProject
{
    partial class HebrewWordMatchGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxWords;
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(188, 38);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(267, 246);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxWords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Items.AddRange(new object[] {
            "כלב",
            "חתול",
            "אדום",
            "חמש",
            "עץ"});
            this.comboBoxWords.Location = new System.Drawing.Point(190, 341);
            this.comboBoxWords.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(265, 24);
            this.comboBoxWords.TabIndex = 1;
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(231, 349);
            this.labelFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 16);
            this.labelFeedback.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSubmit.Location = new System.Drawing.Point(54, 488);
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
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Location = new System.Drawing.Point(524, 488);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 37);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // HebrewWordMatchGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.dreidels_confetti_candies_23_2147968771;
            this.ClientSize = new System.Drawing.Size(697, 570);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HebrewWordMatchGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "התאמת מילה לתמונה";
            this.Load += new System.EventHandler(this.HebrewWordMatchGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
