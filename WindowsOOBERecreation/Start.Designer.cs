namespace WindowsOOBERecreation
{
    partial class Start
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
            this.descriptionOOBE = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.computerNameBox = new System.Windows.Forms.TextBox();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.somethingPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.EOAPic = new System.Windows.Forms.PictureBox();
            this.windowsBrandingPic = new System.Windows.Forms.PictureBox();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EOAPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsBrandingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionOOBE
            // 
            this.descriptionOOBE.AutoSize = true;
            this.descriptionOOBE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionOOBE.Location = new System.Drawing.Point(37, 168);
            this.descriptionOOBE.Name = "descriptionOOBE";
            this.descriptionOOBE.Size = new System.Drawing.Size(514, 15);
            this.descriptionOOBE.TabIndex = 1;
            this.descriptionOOBE.Text = "Choose a user name for your account and name your computer to distinguish it on t" +
    "he network.";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(167, 203);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(206, 15);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Type a user name (for example, John):";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(168, 218);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(240, 23);
            this.usernameBox.TabIndex = 3;
            // 
            // computerNameBox
            // 
            this.computerNameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameBox.Location = new System.Drawing.Point(168, 261);
            this.computerNameBox.Name = "computerNameBox";
            this.computerNameBox.Size = new System.Drawing.Size(240, 23);
            this.computerNameBox.TabIndex = 5;
            this.computerNameBox.Text = "PC";
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerNameLabel.Location = new System.Drawing.Point(165, 242);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(132, 15);
            this.computerNameLabel.TabIndex = 4;
            this.computerNameLabel.Text = "Type a computer name:";
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPanel.Controls.Add(this.somethingPanel);
            this.buttonPanel.Controls.Add(this.nextButton);
            this.buttonPanel.Location = new System.Drawing.Point(0, 426);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(593, 40);
            this.buttonPanel.TabIndex = 6;
            // 
            // somethingPanel
            // 
            this.somethingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.somethingPanel.Location = new System.Drawing.Point(0, 0);
            this.somethingPanel.Name = "somethingPanel";
            this.somethingPanel.Size = new System.Drawing.Size(593, 1);
            this.somethingPanel.TabIndex = 9;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(514, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(69, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(262, 408);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(328, 15);
            this.copyrightLabel.TabIndex = 7;
            this.copyrightLabel.Text = "Copyright © 2009 Microsoft Corporation.  All rights reserved.";
            // 
            // EOAPic
            // 
            this.EOAPic.Image = global::WindowsOOBERecreation.Properties.Resources.image;
            this.EOAPic.Location = new System.Drawing.Point(11, 397);
            this.EOAPic.Name = "EOAPic";
            this.EOAPic.Size = new System.Drawing.Size(24, 24);
            this.EOAPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EOAPic.TabIndex = 8;
            this.EOAPic.TabStop = false;
            // 
            // windowsBrandingPic
            // 
            this.windowsBrandingPic.Image = global::WindowsOOBERecreation.Properties.Resources.branding;
            this.windowsBrandingPic.Location = new System.Drawing.Point(67, 91);
            this.windowsBrandingPic.Name = "windowsBrandingPic";
            this.windowsBrandingPic.Size = new System.Drawing.Size(458, 72);
            this.windowsBrandingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowsBrandingPic.TabIndex = 0;
            this.windowsBrandingPic.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.EOAPic);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.computerNameBox);
            this.Controls.Add(this.computerNameLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.descriptionOOBE);
            this.Controls.Add(this.windowsBrandingPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EOAPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsBrandingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox windowsBrandingPic;
        private System.Windows.Forms.Label descriptionOOBE;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox computerNameBox;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox EOAPic;
        private System.Windows.Forms.Panel somethingPanel;
    }
}

