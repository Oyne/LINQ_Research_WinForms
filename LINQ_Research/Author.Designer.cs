namespace LINQ_Research
{
    partial class Author
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author));
            this.AuthorInformationLabel = new System.Windows.Forms.Label();
            this.AuthorPicture = new System.Windows.Forms.PictureBox();
            this.AuthorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GmailPicture = new System.Windows.Forms.PictureBox();
            this.TelegramPicture = new System.Windows.Forms.PictureBox();
            this.GitHubPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GmailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorInformationLabel
            // 
            this.AuthorInformationLabel.AutoSize = true;
            this.AuthorInformationLabel.Font = new System.Drawing.Font("PokePixel GBA", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInformationLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorInformationLabel.Location = new System.Drawing.Point(337, 54);
            this.AuthorInformationLabel.Name = "AuthorInformationLabel";
            this.AuthorInformationLabel.Size = new System.Drawing.Size(472, 210);
            this.AuthorInformationLabel.TabIndex = 0;
            this.AuthorInformationLabel.Text = "2nd year student \r\nof computer engineering \r\nspecialty in Khai university\r\n\r\nMain" +
    " hobby: Video Games \r\nFavourite series: Pokémon";
            this.AuthorInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorToolTip.SetToolTip(this.AuthorInformationLabel, "About me");
            // 
            // AuthorPicture
            // 
            this.AuthorPicture.Image = ((System.Drawing.Image)(resources.GetObject("AuthorPicture.Image")));
            this.AuthorPicture.Location = new System.Drawing.Point(12, 12);
            this.AuthorPicture.Name = "AuthorPicture";
            this.AuthorPicture.Size = new System.Drawing.Size(318, 426);
            this.AuthorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthorPicture.TabIndex = 1;
            this.AuthorPicture.TabStop = false;
            this.AuthorToolTip.SetToolTip(this.AuthorPicture, "Instagram");
            this.AuthorPicture.Click += new System.EventHandler(this.AuthorPicture_Click);
            // 
            // GmailPicture
            // 
            this.GmailPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GmailPicture.Image = ((System.Drawing.Image)(resources.GetObject("GmailPicture.Image")));
            this.GmailPicture.Location = new System.Drawing.Point(337, 300);
            this.GmailPicture.Name = "GmailPicture";
            this.GmailPicture.Size = new System.Drawing.Size(135, 138);
            this.GmailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GmailPicture.TabIndex = 2;
            this.GmailPicture.TabStop = false;
            this.AuthorToolTip.SetToolTip(this.GmailPicture, "Gmail");
            this.GmailPicture.Click += new System.EventHandler(this.GmailPicture_Click);
            // 
            // TelegramPicture
            // 
            this.TelegramPicture.Image = ((System.Drawing.Image)(resources.GetObject("TelegramPicture.Image")));
            this.TelegramPicture.Location = new System.Drawing.Point(502, 300);
            this.TelegramPicture.Name = "TelegramPicture";
            this.TelegramPicture.Size = new System.Drawing.Size(135, 138);
            this.TelegramPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelegramPicture.TabIndex = 3;
            this.TelegramPicture.TabStop = false;
            this.AuthorToolTip.SetToolTip(this.TelegramPicture, "Telegram");
            this.TelegramPicture.Click += new System.EventHandler(this.TelegramPicture_Click);
            // 
            // GitHubPicture
            // 
            this.GitHubPicture.Image = ((System.Drawing.Image)(resources.GetObject("GitHubPicture.Image")));
            this.GitHubPicture.Location = new System.Drawing.Point(667, 300);
            this.GitHubPicture.Name = "GitHubPicture";
            this.GitHubPicture.Size = new System.Drawing.Size(135, 138);
            this.GitHubPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GitHubPicture.TabIndex = 4;
            this.GitHubPicture.TabStop = false;
            this.AuthorToolTip.SetToolTip(this.GitHubPicture, "GitHub");
            this.GitHubPicture.Click += new System.EventHandler(this.GitHubPicture_Click);
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(this.GitHubPicture);
            this.Controls.Add(this.TelegramPicture);
            this.Controls.Add(this.GmailPicture);
            this.Controls.Add(this.AuthorPicture);
            this.Controls.Add(this.AuthorInformationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author";
            ((System.ComponentModel.ISupportInitialize)(this.AuthorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GmailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorInformationLabel;
        private System.Windows.Forms.PictureBox AuthorPicture;
        private System.Windows.Forms.ToolTip AuthorToolTip;
        private System.Windows.Forms.PictureBox GmailPicture;
        private System.Windows.Forms.PictureBox TelegramPicture;
        private System.Windows.Forms.PictureBox GitHubPicture;
    }
}