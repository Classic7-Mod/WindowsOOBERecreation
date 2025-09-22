﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class Network : Form
    {
        private Main _mainForm;

        public Network(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            AddCommandLink(networkPanel, "Home network", "If all the computers on this network are at your home, and you recognize them, this is a trusted home network. Don't choose this for public places such as coffee shops or airports.", new Icon("C:\\Windows\\Icons\\home.ico", new Size(48, 48)), SetNetwork_Handler, new Size(536, 87), "Home");
            AddCommandLink(networkPanel, "Work network", "If all the computers on this network are at your workplace, and you recognize them, this is a trusted work network. Don't choose this for public places such as coffee shops or airports.", new Icon("C:\\Windows\\Icons\\work.ico", new Size(48, 48)), SetNetwork_Handler, new Size(536, 87), "Work");
            AddCommandLink(networkPanel, "Public network", "If you don't recognize all the computers on the network (for example, you're in a coffee shop or airport, or you have mobile broadband), this is a public network and is not trusted.", new Icon("C:\\Windows\\Icons\\public.ico", new Size(48, 48)), SetNetwork_Handler, new Size(536, 87), "Public");
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

        private void SetNetwork_Handler(object sender, EventArgs e)
        {
            CommandLink cmdLink = (CommandLink)sender;
            string tag = cmdLink.Tag.ToString();

            switch (tag)
            {
                default:
                    Finalizing finalizingForm = new Finalizing(_mainForm);
                    _mainForm.LoadFormIntoPanel(finalizingForm);
                    break;
            }
        }
    }
}
