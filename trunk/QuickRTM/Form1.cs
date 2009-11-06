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
        private Timer statTimer;

        public Form1()
        {
            InitializeComponent();

            statTimer = new Timer();
            statTimer.Tick += new System.EventHandler(this.clearStatusBox);

            dateSelect.Items.Add("Today");
            dateSelect.Items.Add("Tomorrow");

            DateTime dt = DateTime.Now;

            for (int idx = 2; idx < 7; idx++)
            {
                //dt = dt.AddDays(1);
                dateSelect.Items.Add(dt.AddDays(idx).DayOfWeek.ToString());
            }

            dateSelect.SelectedIndex = 0;

            statusBox.Text = "";
            msgTxt.Focus();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            // Send the SMS message
            statusBox.Text = "Sending...";
            statusBox.Update();
            SmsMessage msg = new SmsMessage("40404", "d rtm "+dateSelect.SelectedItem+" " + msgTxt.Text);
            try
            {
                msg.Send();
                msgTxt.Text = "";
                statusBox.Text = "Sent!";
                statusBox.Update();
            }
            catch (Exception err)
            {
                MessageBox.Show("The message could not be sent. Try again in a minute. \r\r Error: " + err.Message);
                statusBox.Text = "Error. Try again.";
                statusBox.Update();
            }
            setClearTimer();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            SmsMessage msg = new SmsMessage("40404", "d rtm !today");
            statusBox.Text = "Sending...";
            statusBox.Update();
            try
            {
                msg.Send();
                statusBox.Text = "List request sent!";
                statusBox.Update();
            }
            catch (Exception err)
            {
                MessageBox.Show("The message could not be sent. Try again in a minute. \r\r Error: " + err.Message);
                statusBox.Text = "Error. Try again.";
                statusBox.Update();
            }
            setClearTimer();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Width > this.Height)
            {
                //MessageBox.Show("landscape");
                logo.Location = new Point(68, 3);
                label1.Location = new Point(70, 68);
                msgTxt.Location = new Point(34, 91);
                msgTxt.Width = 232;
                dateSelect.Location = new Point(34, 125);
                dateSelect.Width = 232;
                statusBox.Location = new Point(31, 159);
                statusBox.Width = 230;
                panel1.Location = new Point(33, 90);
                panel1.Width = 234;
                panel2.Location = new Point(33, 124);
                panel2.Width = 234;
            }
            else
            {
                //MessageBox.Show("portrait");
                logo.Location = new Point(38, 17);
                label1.Location = new Point(40, 97);
                msgTxt.Location = new Point(30, 124);
                msgTxt.Width = 180;
                dateSelect.Location = new Point(30, 163);
                dateSelect.Width = 180;
                statusBox.Location = new Point(30, 219);
                statusBox.Width = 178;
                panel1.Location = new Point(29, 123);
                panel1.Width = 182;
                panel2.Location = new Point(29, 162);
                panel2.Width = 182;
            }
        }

        private void setClearTimer()
        {
            statTimer.Interval = 10000;
            statTimer.Enabled = true;
        }

        private void clearStatusBox(object sender, System.EventArgs e)
        {
            statusBox.Text = "";
            statTimer.Enabled = false;
        }
    }
}