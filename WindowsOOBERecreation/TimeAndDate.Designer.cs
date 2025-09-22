namespace WindowsOOBERecreation
{
    partial class TimeAndDate
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
            this.monthCalBox = new System.Windows.Forms.MonthCalendar();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tzCombo = new System.Windows.Forms.ComboBox();
            this.tzLabel = new System.Windows.Forms.Label();
            this.DSTCheck = new System.Windows.Forms.CheckBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clockBrowser = new System.Windows.Forms.WebBrowser();
            this.timeLabel = new System.Windows.Forms.Label();
            this.somethingPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalBox
            // 
            this.monthCalBox.ForeColor = System.Drawing.Color.White;
            this.monthCalBox.Location = new System.Drawing.Point(37, 193);
            this.monthCalBox.Name = "monthCalBox";
            this.monthCalBox.ShowToday = false;
            this.monthCalBox.TabIndex = 0;
            this.monthCalBox.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalBox_DateChanged);
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPanel.Controls.Add(this.nextButton);
            this.buttonPanel.Location = new System.Drawing.Point(0, 426);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(593, 40);
            this.buttonPanel.TabIndex = 8;
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(514, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(69, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.titleLabel.Location = new System.Drawing.Point(34, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(253, 21);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Review your time and date settings";
            // 
            // tzCombo
            // 
            this.tzCombo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tzCombo.FormattingEnabled = true;
            this.tzCombo.Location = new System.Drawing.Point(39, 115);
            this.tzCombo.Name = "tzCombo";
            this.tzCombo.Size = new System.Drawing.Size(328, 23);
            this.tzCombo.TabIndex = 10;
            // 
            // tzLabel
            // 
            this.tzLabel.AutoSize = true;
            this.tzLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tzLabel.Location = new System.Drawing.Point(37, 90);
            this.tzLabel.Name = "tzLabel";
            this.tzLabel.Size = new System.Drawing.Size(64, 15);
            this.tzLabel.TabIndex = 11;
            this.tzLabel.Text = "Time zone:";
            // 
            // DSTCheck
            // 
            this.DSTCheck.AutoSize = true;
            this.DSTCheck.Checked = true;
            this.DSTCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DSTCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSTCheck.Location = new System.Drawing.Point(38, 148);
            this.DSTCheck.Name = "DSTCheck";
            this.DSTCheck.Size = new System.Drawing.Size(298, 19);
            this.DSTCheck.TabIndex = 12;
            this.DSTCheck.Text = "Automatically adjust clock for Daylight Saving Time";
            this.DSTCheck.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(37, 183);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 15);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date:";
            // 
            // clockBrowser
            // 
            this.clockBrowser.Location = new System.Drawing.Point(298, 196);
            this.clockBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.clockBrowser.Name = "clockBrowser";
            this.clockBrowser.ScrollBarsEnabled = false;
            this.clockBrowser.Size = new System.Drawing.Size(140, 140);
            this.clockBrowser.TabIndex = 14;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(298, 183);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(36, 15);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "Time:";
            // 
            // somethingPanel
            // 
            this.somethingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.somethingPanel.Location = new System.Drawing.Point(0, 426);
            this.somethingPanel.Name = "somethingPanel";
            this.somethingPanel.Size = new System.Drawing.Size(593, 1);
            this.somethingPanel.TabIndex = 16;
            // 
            // TimeAndDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.somethingPanel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.clockBrowser);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.DSTCheck);
            this.Controls.Add(this.tzLabel);
            this.Controls.Add(this.tzCombo);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.monthCalBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeAndDate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalBox;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox tzCombo;
        private System.Windows.Forms.Label tzLabel;
        private System.Windows.Forms.CheckBox DSTCheck;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.WebBrowser clockBrowser;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel somethingPanel;
    }
}