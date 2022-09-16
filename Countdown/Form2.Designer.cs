namespace Countdown
{
    partial class Form2
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
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ByLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WebsiteButton = new System.Windows.Forms.Button();
            this.DiscordButton = new System.Windows.Forms.Button();
            this.GithubButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(12, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(146, 30);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "Countdown v";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByLabel.Location = new System.Drawing.Point(15, 56);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(27, 21);
            this.ByLabel.TabIndex = 1;
            this.ByLabel.Text = "by";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Countdown.Properties.Resources.logo_wide;
            this.pictureBox1.Location = new System.Drawing.Point(48, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Countdown is a free and open-source\r\ntool to configure a countdown clock!\r\n\r\nNeed" +
    " help? Take a look at the README\r\non GitHub for a detailed example.";
            // 
            // WebsiteButton
            // 
            this.WebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WebsiteButton.Location = new System.Drawing.Point(12, 192);
            this.WebsiteButton.Name = "WebsiteButton";
            this.WebsiteButton.Size = new System.Drawing.Size(69, 23);
            this.WebsiteButton.TabIndex = 1;
            this.WebsiteButton.Text = "Website";
            this.WebsiteButton.UseVisualStyleBackColor = true;
            this.WebsiteButton.Click += new System.EventHandler(this.WebsiteButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DiscordButton.Location = new System.Drawing.Point(158, 192);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(69, 23);
            this.DiscordButton.TabIndex = 3;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // GithubButton
            // 
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GithubButton.Location = new System.Drawing.Point(85, 192);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(69, 23);
            this.GithubButton.TabIndex = 2;
            this.GithubButton.Text = "GitHub";
            this.GithubButton.UseVisualStyleBackColor = true;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 226);
            this.Controls.Add(this.GithubButton);
            this.Controls.Add(this.DiscordButton);
            this.Controls.Add(this.WebsiteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ByLabel);
            this.Controls.Add(this.VersionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "About Countdown";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label VersionLabel;
        private Label ByLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button WebsiteButton;
        private Button DiscordButton;
        private Button GithubButton;
    }
}