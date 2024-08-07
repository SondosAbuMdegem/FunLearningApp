namespace FinalProject
{
    partial class EnglishLetterOrderGameForm
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
            this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(67, 33);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(325, 31);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Type the letters in order";
            this.labelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(136, 94);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(132, 22);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(163, 165);
            this.labelFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(69, 16);
            this.labelFeedback.TabIndex = 2;
            this.labelFeedback.Text = "";
            this.labelFeedback.Click += new System.EventHandler(this.labelFeedback_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(135, 231);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(133, 37);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "בדוק";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(135, 292);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 37);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EnglishLetterOrderGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelPrompt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnglishLetterOrderGameForm";
            this.Text = "Alphabetical Order Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
