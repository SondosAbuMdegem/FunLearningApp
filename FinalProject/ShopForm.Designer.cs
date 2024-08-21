namespace FinalProject
{
    partial class ShopForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.ListBox listBoxStickers;
        private System.Windows.Forms.ListBox listBoxToys;
        private System.Windows.Forms.ListBox listBoxPencilCases;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.TabControl tabControlCategories;
        private System.Windows.Forms.TabPage tabPageStickers;
        private System.Windows.Forms.TabPage tabPageToys;
        private System.Windows.Forms.TabPage tabPagePencilCases;
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
            this.labelCoins = new System.Windows.Forms.Label();
            this.listBoxStickers = new System.Windows.Forms.ListBox();
            this.listBoxToys = new System.Windows.Forms.ListBox();
            this.listBoxPencilCases = new System.Windows.Forms.ListBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.tabControlCategories = new System.Windows.Forms.TabControl();
            this.tabPageStickers = new System.Windows.Forms.TabPage();
            this.tabPageToys = new System.Windows.Forms.TabPage();
            this.tabPagePencilCases = new System.Windows.Forms.TabPage();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.tabControlCategories.SuspendLayout();
            this.tabPageStickers.SuspendLayout();
            this.tabPageToys.SuspendLayout();
            this.tabPagePencilCases.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCoins.Location = new System.Drawing.Point(544, 15);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(153, 29);
            this.labelCoins.TabIndex = 0;
            this.labelCoins.Text = "מטבעות זמינים\r\n";
            // 
            // listBoxStickers
            // 
            this.listBoxStickers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxStickers.FormattingEnabled = true;
            this.listBoxStickers.ItemHeight = 16;
            this.listBoxStickers.Items.AddRange(new object[] {
            "מדבקות בצבע אדום - 40 מטבעות",
            "מדבקות בצבע כחול - 40 מטבעות",
            "מדבקות בצבע ירוק - 40 מטבעות",
            "מדבקות צבעוניות - 50 מטבעות"});
            this.listBoxStickers.Location = new System.Drawing.Point(33, 0);
            this.listBoxStickers.Name = "listBoxStickers";
            this.listBoxStickers.Size = new System.Drawing.Size(374, 244);
            this.listBoxStickers.TabIndex = 1;
            this.listBoxStickers.SelectedIndexChanged += new System.EventHandler(this.listBoxStickers_SelectedIndexChanged);
            // 
            // listBoxToys
            // 
            this.listBoxToys.FormattingEnabled = true;
            this.listBoxToys.ItemHeight = 16;
            this.listBoxToys.Items.AddRange(new object[] {
            "בובה עדינה - 100 מטבעות",
            "רכב קיה - 150 מטבעות",
            "רכב לימוזינה - 200 מטבעות",
            "מזוודת סליים - 250 מטבעות"});
            this.listBoxToys.Location = new System.Drawing.Point(6, 6);
            this.listBoxToys.Name = "listBoxToys";
            this.listBoxToys.Size = new System.Drawing.Size(370, 292);
            this.listBoxToys.TabIndex = 2;
            this.listBoxToys.SelectedIndexChanged += new System.EventHandler(this.listBoxToys_SelectedIndexChanged);
            // 
            // listBoxPencilCases
            // 
            this.listBoxPencilCases.FormattingEnabled = true;
            this.listBoxPencilCases.ItemHeight = 16;
            this.listBoxPencilCases.Items.AddRange(new object[] {
            "קלמר ורוד - 90 מטבעות",
            "קלמר כחול - 90 מטבעות",
            "קלמר ורוד כדורגל - 150 מטבעות",
            "קלמר מגרש כדורגל - 150 מטבעות"});
            this.listBoxPencilCases.Location = new System.Drawing.Point(6, 6);
            this.listBoxPencilCases.Name = "listBoxPencilCases";
            this.listBoxPencilCases.Size = new System.Drawing.Size(370, 292);
            this.listBoxPencilCases.TabIndex = 3;
            this.listBoxPencilCases.SelectedIndexChanged += new System.EventHandler(this.listBoxPencilCases_SelectedIndexChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBuy.ForeColor = System.Drawing.Color.White;
            this.buttonBuy.Location = new System.Drawing.Point(598, 477);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(105, 38);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "קנה";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBoxProduct.Location = new System.Drawing.Point(12, 72);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(189, 190);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 5;
            this.pictureBoxProduct.TabStop = false;
            // 
            // tabControlCategories
            // 
            this.tabControlCategories.Controls.Add(this.tabPageStickers);
            this.tabControlCategories.Controls.Add(this.tabPageToys);
            this.tabControlCategories.Controls.Add(this.tabPagePencilCases);
            this.tabControlCategories.Location = new System.Drawing.Point(306, 47);
            this.tabControlCategories.Name = "tabControlCategories";
            this.tabControlCategories.SelectedIndex = 0;
            this.tabControlCategories.Size = new System.Drawing.Size(418, 268);
            this.tabControlCategories.TabIndex = 6;
            // 
            // tabPageStickers
            // 
            this.tabPageStickers.Controls.Add(this.listBoxStickers);
            this.tabPageStickers.Location = new System.Drawing.Point(4, 25);
            this.tabPageStickers.Name = "tabPageStickers";
            this.tabPageStickers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStickers.Size = new System.Drawing.Size(410, 239);
            this.tabPageStickers.TabIndex = 0;
            this.tabPageStickers.Text = "מדבקות";
            this.tabPageStickers.UseVisualStyleBackColor = true;
            // 
            // tabPageToys
            // 
            this.tabPageToys.Controls.Add(this.listBoxToys);
            this.tabPageToys.Location = new System.Drawing.Point(4, 25);
            this.tabPageToys.Name = "tabPageToys";
            this.tabPageToys.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageToys.Size = new System.Drawing.Size(212, 186);
            this.tabPageToys.TabIndex = 1;
            this.tabPageToys.Text = "צעצועים";
            this.tabPageToys.UseVisualStyleBackColor = true;
            // 
            // tabPagePencilCases
            // 
            this.tabPagePencilCases.Controls.Add(this.listBoxPencilCases);
            this.tabPagePencilCases.Location = new System.Drawing.Point(4, 25);
            this.tabPagePencilCases.Name = "tabPagePencilCases";
            this.tabPagePencilCases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePencilCases.Size = new System.Drawing.Size(212, 186);
            this.tabPagePencilCases.TabIndex = 2;
            this.tabPagePencilCases.Text = "קלמרים";
            this.tabPagePencilCases.UseVisualStyleBackColor = true;
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBackToMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBackToMain.Location = new System.Drawing.Point(26, 487);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(105, 38);
            this.buttonBackToMain.TabIndex = 7;
            this.buttonBackToMain.Text = "חזור";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.cartoon_like_kid_playing_with_board_game_indoors_23_2150898561;
            this.ClientSize = new System.Drawing.Size(736, 576);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.tabControlCategories);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelCoins);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "חנות";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.tabControlCategories.ResumeLayout(false);
            this.tabPageStickers.ResumeLayout(false);
            this.tabPageToys.ResumeLayout(false);
            this.tabPagePencilCases.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
