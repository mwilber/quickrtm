namespace QuickRTM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.msgTxt = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.Label();
            this.dateSelect = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Send";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Get List";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // msgTxt
            // 
            this.msgTxt.Location = new System.Drawing.Point(30, 124);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(180, 30);
            this.msgTxt.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(38, 17);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(164, 63);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(40, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.Text = "What do you need to do?";
            // 
            // statusBox
            // 
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.statusBox.Location = new System.Drawing.Point(30, 219);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(180, 20);
            this.statusBox.Text = "loading...";
            // 
            // dateSelect
            // 
            this.dateSelect.Location = new System.Drawing.Point(30, 163);
            this.dateSelect.Name = "dateSelect";
            this.dateSelect.Size = new System.Drawing.Size(180, 30);
            this.dateSelect.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(29, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 30);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(29, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 32);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(131F, 131F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(240, 266);
            this.Controls.Add(this.dateSelect);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "QuickRTM";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TextBox msgTxt;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label statusBox;
        private System.Windows.Forms.ComboBox dateSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

