namespace FinalProject
{
    partial class MultiplicationGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(100, 50);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(150, 31);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "השאלה";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(100, 100);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(150, 22);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(100, 150);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 30);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "בדוק";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(100, 200);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 30);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MultiplicationGameForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Name = "MultiplicationGameForm";
            this.Text = "Multiplication Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
