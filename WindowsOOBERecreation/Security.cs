﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Security : Form
    {
        private Main _mainForm;

        public Security(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            // I have FINALLY, after a few months figured out how to make command links with icons. This really adds color to the OOBE. 
            AddCommandLink(securityPanel, "Use recommended settings", "Install important and recommended updates, help make Internet browsing safer, check online for solutions to problems, and help Microsoft improve Windows.", new Icon("C:\\Windows\\Icons\\recommended.ico", new Size(48, 48)), SetPrivacy_Handler, new Size(536, 72), "Recommended");
            AddCommandLink(securityPanel, "Install important updates only", "Only install security updates and other important updates for Windows.", new Icon("C:\\Windows\\Icons\\recommended-32.ico", new Size(48, 48)), SetPrivacy_Handler, new Size(536, 57), "Important");
            AddCommandLink(securityPanel, "Ask me later", "Until you decide, your computer might be vulnerable to security threats.", new Icon("C:\\Windows\\Icons\\ask-32.ico", new Size(48, 48)), SetPrivacy_Handler, new Size(536, 57), "Later"); 
        }

        private void AddCommandLink(Panel targetPanel, string text, string note, Icon icon, EventHandler onClick, Size? size = null, string tag = "")
        {
            CommandLink cmdLink = new CommandLink
            {
                Text = text,
                Note = note,
                Icon = icon,
                Size = size ?? new Size(500, 60),
                Tag = tag
            };

            if (onClick != null)
            {
                cmdLink.Click += onClick;
            }

            cmdLink.Margin = new Padding(0);
            targetPanel.Controls.Add(cmdLink);
        }

        private void SetPrivacy_Handler(object sender, EventArgs e)
        {
            CommandLink cmdLink = (CommandLink)sender;
            string tag = cmdLink.Tag.ToString();

            switch (tag)
            {
                default:
                    TimeAndDate timeAndDateForm = new TimeAndDate(_mainForm);
                    _mainForm.LoadFormIntoPanel(timeAndDateForm);
                    break;
            }
        }
    }
}
