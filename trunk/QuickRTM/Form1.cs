using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.WindowsMobile.Forms;
using Microsoft.WindowsMobile.PocketOutlook;
using Microsoft.WindowsMobile.PocketOutlook.MessageInterception;

namespace QuickRTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            msgTxt.Focus();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            // Send the SMS message
            SmsMessage msg = new SmsMessage("40404", "d rtm today " + msgTxt.Text);
            msg.Send();
            msgTxt.Text = "";
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            SmsMessage msg = new SmsMessage("40404", "d rtm !today");
            msg.Send();
        }
    }
}