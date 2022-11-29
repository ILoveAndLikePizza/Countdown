namespace Countdown
{
    partial class Form3
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
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountdownLabel.Location = new System.Drawing.Point(12, 9);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(487, 114);
            this.CountdownLabel.TabIndex = 0;
            this.CountdownLabel.Text = "13:37:00";
            this.CountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtitleLabel.Location = new System.Drawing.Point(12, 145);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(487, 112);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Bottom Text";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 266);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CountdownLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.DoubleClick += new System.EventHandler(this.Form3_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private Label CountdownLabel;
        private Label SubtitleLabel;
    }
}