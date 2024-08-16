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
            this.buttonGames.BackColor = System.Drawing.Color.Sienna;
            this.buttonGames.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGames.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonGames.Location = new System.Drawing.Point(151, 114);
            this.buttonGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGames.Name = "buttonGames";
            this.buttonGames.Size = new System.Drawing.Size(133, 57);
            this.buttonGames.TabIndex = 0;
            this.buttonGames.Text = "משחקי לימוד";
            this.buttonGames.UseVisualStyleBackColor = false;
            this.buttonGames.Click += new System.EventHandler(this.buttonGames_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.BackColor = System.Drawing.Color.Sienna;
            this.buttonShop.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShop.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonShop.Location = new System.Drawing.Point(292, 165);
            this.buttonShop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(133, 57);
            this.buttonShop.TabIndex = 1;
            this.buttonShop.Text = "חנות";
            this.buttonShop.UseVisualStyleBackColor = false;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click_1);
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.BackColor = System.Drawing.Color.Sienna;
            this.buttonUserInfo.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserInfo.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonUserInfo.Location = new System.Drawing.Point(151, 207);
            this.buttonUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(133, 57);
            this.buttonUserInfo.TabIndex = 2;
            this.buttonUserInfo.Text = "הצגת משתמש";
            this.buttonUserInfo.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(229, 272);
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
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelTitle.Location = new System.Drawing.Point(353, 90);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "דף ראשי";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.Screenshot_2024_08_15_113648;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUserInfo);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonGames);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
