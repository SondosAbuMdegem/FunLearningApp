namespace FinalProject
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonGames;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;

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
            this.buttonGames = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGames
            // 
            this.buttonGames.Location = new System.Drawing.Point(193, 119);
            this.buttonGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGames.Name = "buttonGames";
            this.buttonGames.Size = new System.Drawing.Size(133, 37);
            this.buttonGames.TabIndex = 0;
            this.buttonGames.Text = "משחקי לימוד";
            this.buttonGames.UseVisualStyleBackColor = true;
            // 
            // buttonShop
            // 
            this.buttonShop.Location = new System.Drawing.Point(193, 191);
            this.buttonShop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(133, 37);
            this.buttonShop.TabIndex = 1;
            this.buttonShop.Text = "חנות";
            this.buttonShop.UseVisualStyleBackColor = true;
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Location = new System.Drawing.Point(193, 264);
            this.buttonUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(133, 37);
            this.buttonUserInfo.TabIndex = 2;
            this.buttonUserInfo.Text = "הצגת משתמש";
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(193, 350);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 37);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "יציאה";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(194, 35);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(132, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "מסך ראשי";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUserInfo);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonGames);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
