namespace WindowsOOBERecreation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.basicPanel = new System.Windows.Forms.Panel();
            this.backButtonPic = new System.Windows.Forms.PictureBox();
            this.iconPicBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.basicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButtonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // basicPanel
            // 
            this.basicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.basicPanel.Controls.Add(this.backButtonPic);
            this.basicPanel.Controls.Add(this.iconPicBox);
            this.basicPanel.Controls.Add(this.titleLabel);
            this.basicPanel.Location = new System.Drawing.Point(0, 0);
            this.basicPanel.Name = "basicPanel";
            this.basicPanel.Size = new System.Drawing.Size(593, 31);
            this.basicPanel.TabIndex = 0;
            // 
            // backButtonPic
            // 
            this.backButtonPic.BackColor = System.Drawing.Color.Transparent;
            this.backButtonPic.Image = ((System.Drawing.Image)(resources.GetObject("backButtonPic.Image")));
            this.backButtonPic.Location = new System.Drawing.Point(0, -1);
            this.backButtonPic.Name = "backButtonPic";
            this.backButtonPic.Size = new System.Drawing.Size(31, 31);
            this.backButtonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButtonPic.TabIndex = 2;
            this.backButtonPic.TabStop = false;
            // 
            // iconPicBox
            // 
            this.iconPicBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPicBox.Image = global::WindowsOOBERecreation.Properties.Resources.wysi_icon_10;
            this.iconPicBox.Location = new System.Drawing.Point(37, 6);
            this.iconPicBox.Name = "iconPicBox";
            this.iconPicBox.Size = new System.Drawing.Size(16, 16);
            this.iconPicBox.TabIndex = 2;
            this.iconPicBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(57, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(93, 15);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Set Up Windows";
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(191)))), ((int)(((byte)(214)))));
            this.displayPanel.Location = new System.Drawing.Point(0, 30);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(593, 1);
            this.displayPanel.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.ControlBox = false;
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.basicPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "‎ ";
            this.basicPanel.ResumeLayout(false);
            this.basicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButtonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basicPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.PictureBox iconPicBox;
        public System.Windows.Forms.PictureBox backButtonPic;
    }
}