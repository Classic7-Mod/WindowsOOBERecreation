namespace WindowsOOBERecreation
{
    partial class ProductKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductKey));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.skipButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.prodKeySimLabel = new System.Windows.Forms.Label();
            this.prodKeyIELabel = new System.Windows.Forms.Label();
            this.productKeyBox = new System.Windows.Forms.TextBox();
            this.dashLabel = new System.Windows.Forms.Label();
            this.activateOnlineCheck = new System.Windows.Forms.CheckBox();
            this.WIALabel = new System.Windows.Forms.LinkLabel();
            this.PSLabel = new System.Windows.Forms.LinkLabel();
            this.somethingPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPanel.Controls.Add(this.skipButton);
            this.buttonPanel.Controls.Add(this.nextButton);
            this.buttonPanel.Location = new System.Drawing.Point(0, 426);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(593, 40);
            this.buttonPanel.TabIndex = 9;
            // 
            // skipButton
            // 
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.skipButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.Location = new System.Drawing.Point(439, 8);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(69, 23);
            this.skipButton.TabIndex = 8;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
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
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(37, 90);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(499, 45);
            this.descriptionLabel.TabIndex = 18;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.titleLabel.Location = new System.Drawing.Point(35, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(233, 21);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Type your Windows product key";
            // 
            // prodKeySimLabel
            // 
            this.prodKeySimLabel.AutoSize = true;
            this.prodKeySimLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodKeySimLabel.Location = new System.Drawing.Point(37, 153);
            this.prodKeySimLabel.Name = "prodKeySimLabel";
            this.prodKeySimLabel.Size = new System.Drawing.Size(200, 15);
            this.prodKeySimLabel.TabIndex = 19;
            this.prodKeySimLabel.Text = "The product key looks similar to this:";
            // 
            // prodKeyIELabel
            // 
            this.prodKeyIELabel.AutoSize = true;
            this.prodKeyIELabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prodKeyIELabel.Location = new System.Drawing.Point(37, 177);
            this.prodKeyIELabel.Name = "prodKeyIELabel";
            this.prodKeyIELabel.Size = new System.Drawing.Size(284, 15);
            this.prodKeyIELabel.TabIndex = 20;
            this.prodKeyIELabel.Text = "PRODUCT KEY: XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";
            // 
            // productKeyBox
            // 
            this.productKeyBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productKeyBox.Location = new System.Drawing.Point(38, 203);
            this.productKeyBox.Name = "productKeyBox";
            this.productKeyBox.Size = new System.Drawing.Size(356, 20);
            this.productKeyBox.TabIndex = 21;
            this.productKeyBox.TextChanged += new System.EventHandler(this.ProductKeyBox_TextChanged);
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashLabel.Location = new System.Drawing.Point(37, 225);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(199, 15);
            this.dashLabel.TabIndex = 22;
            this.dashLabel.Text = "(dashes will be added automatically)";
            // 
            // activateOnlineCheck
            // 
            this.activateOnlineCheck.AutoSize = true;
            this.activateOnlineCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.activateOnlineCheck.Location = new System.Drawing.Point(38, 256);
            this.activateOnlineCheck.Name = "activateOnlineCheck";
            this.activateOnlineCheck.Size = new System.Drawing.Size(284, 19);
            this.activateOnlineCheck.TabIndex = 23;
            this.activateOnlineCheck.Text = "Automatically activate Windows when I\'m online";
            this.activateOnlineCheck.UseVisualStyleBackColor = true;
            // 
            // WIALabel
            // 
            this.WIALabel.AutoSize = true;
            this.WIALabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WIALabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.WIALabel.Location = new System.Drawing.Point(35, 351);
            this.WIALabel.Name = "WIALabel";
            this.WIALabel.Size = new System.Drawing.Size(106, 15);
            this.WIALabel.TabIndex = 24;
            this.WIALabel.TabStop = true;
            this.WIALabel.Text = "What is activation?";
            // 
            // PSLabel
            // 
            this.PSLabel.AutoSize = true;
            this.PSLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PSLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PSLabel.Location = new System.Drawing.Point(35, 370);
            this.PSLabel.Name = "PSLabel";
            this.PSLabel.Size = new System.Drawing.Size(151, 15);
            this.PSLabel.TabIndex = 25;
            this.PSLabel.TabStop = true;
            this.PSLabel.Text = "Read our privacy statement";
            // 
            // somethingPanel
            // 
            this.somethingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.somethingPanel.Location = new System.Drawing.Point(0, 426);
            this.somethingPanel.Name = "somethingPanel";
            this.somethingPanel.Size = new System.Drawing.Size(593, 1);
            this.somethingPanel.TabIndex = 26;
            // 
            // ProductKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 466);
            this.Controls.Add(this.somethingPanel);
            this.Controls.Add(this.PSLabel);
            this.Controls.Add(this.WIALabel);
            this.Controls.Add(this.activateOnlineCheck);
            this.Controls.Add(this.dashLabel);
            this.Controls.Add(this.productKeyBox);
            this.Controls.Add(this.prodKeyIELabel);
            this.Controls.Add(this.prodKeySimLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buttonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductKey";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ProductKey_Load);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label prodKeySimLabel;
        private System.Windows.Forms.Label prodKeyIELabel;
        private System.Windows.Forms.TextBox productKeyBox;
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.CheckBox activateOnlineCheck;
        private System.Windows.Forms.LinkLabel WIALabel;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.LinkLabel PSLabel;
        private System.Windows.Forms.Panel somethingPanel;
    }
}