#pragma warning disable CS0108

namespace Countdown
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DayInput = new System.Windows.Forms.DateTimePicker();
            this.AtLabel = new System.Windows.Forms.Label();
            this.HourInput = new System.Windows.Forms.NumericUpDown();
            this.MinuteInput = new System.Windows.Forms.NumericUpDown();
            this.SecondInput = new System.Windows.Forms.NumericUpDown();
            this.Colon1 = new System.Windows.Forms.Label();
            this.Colon2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Subtitle = new System.Windows.Forms.TextBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HitsZeroAction = new System.Windows.Forms.ComboBox();
            this.HitsZeroLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DoAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HourInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondInput)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DayInput
            // 
            this.DayInput.Location = new System.Drawing.Point(10, 11);
            this.DayInput.Name = "DayInput";
            this.DayInput.Size = new System.Drawing.Size(200, 23);
            this.DayInput.TabIndex = 0;
            this.DayInput.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // AtLabel
            // 
            this.AtLabel.AutoSize = true;
            this.AtLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AtLabel.Location = new System.Drawing.Point(15, 48);
            this.AtLabel.Name = "AtLabel";
            this.AtLabel.Size = new System.Drawing.Size(17, 15);
            this.AtLabel.TabIndex = 1;
            this.AtLabel.Text = "at";
            // 
            // HourInput
            // 
            this.HourInput.Location = new System.Drawing.Point(43, 44);
            this.HourInput.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourInput.Name = "HourInput";
            this.HourInput.Size = new System.Drawing.Size(47, 23);
            this.HourInput.TabIndex = 2;
            // 
            // MinuteInput
            // 
            this.MinuteInput.Location = new System.Drawing.Point(103, 44);
            this.MinuteInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteInput.Name = "MinuteInput";
            this.MinuteInput.Size = new System.Drawing.Size(47, 23);
            this.MinuteInput.TabIndex = 3;
            // 
            // SecondInput
            // 
            this.SecondInput.Location = new System.Drawing.Point(163, 44);
            this.SecondInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondInput.Name = "SecondInput";
            this.SecondInput.Size = new System.Drawing.Size(47, 23);
            this.SecondInput.TabIndex = 4;
            // 
            // Colon1
            // 
            this.Colon1.AutoSize = true;
            this.Colon1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Colon1.Location = new System.Drawing.Point(92, 48);
            this.Colon1.Name = "Colon1";
            this.Colon1.Size = new System.Drawing.Size(10, 15);
            this.Colon1.TabIndex = 5;
            this.Colon1.Text = ":";
            // 
            // Colon2
            // 
            this.Colon2.AutoSize = true;
            this.Colon2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Colon2.Location = new System.Drawing.Point(152, 48);
            this.Colon2.Name = "Colon2";
            this.Colon2.Size = new System.Drawing.Size(10, 15);
            this.Colon2.TabIndex = 6;
            this.Colon2.Text = ":";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(233, 106);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Colon2);
            this.tabPage1.Controls.Add(this.DayInput);
            this.tabPage1.Controls.Add(this.AtLabel);
            this.tabPage1.Controls.Add(this.Colon1);
            this.tabPage1.Controls.Add(this.MinuteInput);
            this.tabPage1.Controls.Add(this.HourInput);
            this.tabPage1.Controls.Add(this.SecondInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(225, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Countdown";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Subtitle);
            this.tabPage2.Controls.Add(this.SubtitleLabel);
            this.tabPage2.Controls.Add(this.SetColorButton);
            this.tabPage2.Controls.Add(this.ColorLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(225, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Window";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Subtitle
            // 
            this.Subtitle.Location = new System.Drawing.Point(73, 43);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(136, 23);
            this.Subtitle.TabIndex = 4;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Location = new System.Drawing.Point(6, 46);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(50, 15);
            this.SubtitleLabel.TabIndex = 3;
            this.SubtitleLabel.Text = "Subtitle:";
            // 
            // SetColorButton
            // 
            this.SetColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SetColorButton.Location = new System.Drawing.Point(106, 9);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(103, 23);
            this.SetColorButton.TabIndex = 2;
            this.SetColorButton.Text = "Select...";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(6, 13);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(84, 15);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Window color:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.HitsZeroAction);
            this.tabPage3.Controls.Add(this.HitsZeroLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(225, 78);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Action";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HitsZeroAction
            // 
            this.HitsZeroAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HitsZeroAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HitsZeroAction.FormattingEnabled = true;
            this.HitsZeroAction.Items.AddRange(new object[] {
            "Do nothing",
            "Play sound",
            "Show message box",
            "Quit application",
            "Shutdown the computer"});
            this.HitsZeroAction.Location = new System.Drawing.Point(12, 36);
            this.HitsZeroAction.Name = "HitsZeroAction";
            this.HitsZeroAction.Size = new System.Drawing.Size(198, 23);
            this.HitsZeroAction.TabIndex = 1;
            // 
            // HitsZeroLabel
            // 
            this.HitsZeroLabel.AutoSize = true;
            this.HitsZeroLabel.Location = new System.Drawing.Point(10, 14);
            this.HitsZeroLabel.Name = "HitsZeroLabel";
            this.HitsZeroLabel.Size = new System.Drawing.Size(136, 15);
            this.HitsZeroLabel.TabIndex = 0;
            this.HitsZeroLabel.Text = "When countdown hits 0:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DoAlwaysOnTop);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(225, 78);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "System";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DoAlwaysOnTop
            // 
            this.DoAlwaysOnTop.AutoSize = true;
            this.DoAlwaysOnTop.Checked = true;
            this.DoAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoAlwaysOnTop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoAlwaysOnTop.Location = new System.Drawing.Point(9, 30);
            this.DoAlwaysOnTop.Name = "DoAlwaysOnTop";
            this.DoAlwaysOnTop.Size = new System.Drawing.Size(210, 20);
            this.DoAlwaysOnTop.TabIndex = 0;
            this.DoAlwaysOnTop.Text = "Display countdown always on top";
            this.DoAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveButton.Location = new System.Drawing.Point(170, 117);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(64, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelButton.Location = new System.Drawing.Point(100, 117);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(64, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AboutButton.Location = new System.Drawing.Point(9, 117);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(57, 23);
            this.AboutButton.TabIndex = 11;
            this.AboutButton.Text = "About...";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(243, 149);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HourInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondInput)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker DayInput;
        private Label AtLabel;
        private NumericUpDown HourInput;
        private NumericUpDown MinuteInput;
        private NumericUpDown SecondInput;
        private Label Colon1;
        private Label Colon2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox Subtitle;
        private Label SubtitleLabel;
        private Button SetColorButton;
        private Label ColorLabel;
        private TabPage tabPage3;
        private ComboBox HitsZeroAction;
        private Label HitsZeroLabel;
        private Button SaveButton;
        private Button CancelButton;
        private Button AboutButton;
        private TabPage tabPage4;
        private CheckBox DoRunAtStart;
        private CheckBox DoAlwaysOnTop;
    }
}