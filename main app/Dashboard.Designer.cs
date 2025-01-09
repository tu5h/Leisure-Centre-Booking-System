namespace NEA___D1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contactUsButton = new System.Windows.Forms.Button();
            this.PurposeButton = new System.Windows.Forms.Button();
            this.offersButton = new System.Windows.Forms.Button();
            this.dealsButton = new System.Windows.Forms.Button();
            this.busyButton = new System.Windows.Forms.Panel();
            this.NotificationsPanel = new System.Windows.Forms.Panel();
            this.notificationsTxtBox = new System.Windows.Forms.TextBox();
            this.buttonPanel2 = new System.Windows.Forms.Panel();
            this.myBookingsButton = new System.Windows.Forms.Button();
            this.buttonPanel3 = new System.Windows.Forms.Panel();
            this.quickGymButton = new System.Windows.Forms.Button();
            this.buttonPanel5 = new System.Windows.Forms.Panel();
            this.myAccountsButton = new System.Windows.Forms.Button();
            this.buttonPanel4 = new System.Windows.Forms.Panel();
            this.clubBookingsButton = new System.Windows.Forms.Button();
            this.buttonPanel1 = new System.Windows.Forms.Panel();
            this.bookNowButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.busyTxt = new System.Windows.Forms.Label();
            this.busyTxtBox1 = new System.Windows.Forms.TextBox();
            this.notifcationTxt = new System.Windows.Forms.Label();
            this.busyTxtBox2 = new System.Windows.Forms.TextBox();
            this.busyTxtBox3 = new System.Windows.Forms.TextBox();
            this.centre1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.topLeftIconPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            this.busyButton.SuspendLayout();
            this.NotificationsPanel.SuspendLayout();
            this.buttonPanel2.SuspendLayout();
            this.buttonPanel3.SuspendLayout();
            this.buttonPanel5.SuspendLayout();
            this.buttonPanel4.SuspendLayout();
            this.buttonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Location = new System.Drawing.Point(0, 66);
            this.LeftSideBarPanel.Size = new System.Drawing.Size(200, 558);
            // 
            // topLeftIconPanel
            // 
            this.topLeftIconPanel.Controls.Add(this.pictureBox1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.topBarPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 66);
            this.panel1.TabIndex = 1;
            // 
            // topBarPanel
            // 
            this.topBarPanel.ColumnCount = 7;
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72587F));
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72588F));
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72588F));
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72588F));
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72588F));
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.72451F));
            this.topBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.6461F));
            this.topBarPanel.Controls.Add(this.contactUsButton, 5, 0);
            this.topBarPanel.Controls.Add(this.PurposeButton, 3, 0);
            this.topBarPanel.Controls.Add(this.offersButton, 4, 0);
            this.topBarPanel.Controls.Add(this.dealsButton, 2, 0);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.RowCount = 1;
            this.topBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topBarPanel.Size = new System.Drawing.Size(1301, 66);
            this.topBarPanel.TabIndex = 0;
            // 
            // contactUsButton
            // 
            this.contactUsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactUsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.contactUsButton.ForeColor = System.Drawing.Color.Ivory;
            this.contactUsButton.Location = new System.Drawing.Point(893, 3);
            this.contactUsButton.Name = "contactUsButton";
            this.contactUsButton.Size = new System.Drawing.Size(172, 60);
            this.contactUsButton.TabIndex = 2;
            this.contactUsButton.Text = "CONTACT US";
            this.contactUsButton.UseVisualStyleBackColor = true;
            this.contactUsButton.Click += new System.EventHandler(this.contactUsButton_Click_1);
            // 
            // PurposeButton
            // 
            this.PurposeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurposeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurposeButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.PurposeButton.ForeColor = System.Drawing.Color.Ivory;
            this.PurposeButton.Location = new System.Drawing.Point(537, 3);
            this.PurposeButton.Name = "PurposeButton";
            this.PurposeButton.Size = new System.Drawing.Size(172, 60);
            this.PurposeButton.TabIndex = 2;
            this.PurposeButton.Text = "OUR PURPOSE ";
            this.PurposeButton.UseVisualStyleBackColor = true;
            this.PurposeButton.Click += new System.EventHandler(this.PurposeButton_Click);
            // 
            // offersButton
            // 
            this.offersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offersButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.offersButton.ForeColor = System.Drawing.Color.Ivory;
            this.offersButton.Location = new System.Drawing.Point(715, 3);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(172, 60);
            this.offersButton.TabIndex = 2;
            this.offersButton.Text = "OUR OFFERS";
            this.offersButton.UseVisualStyleBackColor = true;
            this.offersButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // dealsButton
            // 
            this.dealsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.dealsButton.ForeColor = System.Drawing.Color.Ivory;
            this.dealsButton.Location = new System.Drawing.Point(359, 3);
            this.dealsButton.Name = "dealsButton";
            this.dealsButton.Size = new System.Drawing.Size(172, 60);
            this.dealsButton.TabIndex = 2;
            this.dealsButton.Text = "OUR DEALS";
            this.dealsButton.UseVisualStyleBackColor = true;
            this.dealsButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // busyButton
            // 
            this.busyButton.Controls.Add(this.busyTxtBox3);
            this.busyButton.Controls.Add(this.busyTxtBox2);
            this.busyButton.Controls.Add(this.busyTxtBox1);
            this.busyButton.Controls.Add(this.NotificationsPanel);
            this.busyButton.Controls.Add(this.label2);
            this.busyButton.Controls.Add(this.label1);
            this.busyButton.Controls.Add(this.centre1Label);
            this.busyButton.Controls.Add(this.busyTxt);
            this.busyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.busyButton.Location = new System.Drawing.Point(1101, 66);
            this.busyButton.Name = "busyButton";
            this.busyButton.Size = new System.Drawing.Size(200, 558);
            this.busyButton.TabIndex = 2;
            // 
            // NotificationsPanel
            // 
            this.NotificationsPanel.Controls.Add(this.notificationsTxtBox);
            this.NotificationsPanel.Controls.Add(this.notifcationTxt);
            this.NotificationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NotificationsPanel.Location = new System.Drawing.Point(0, 245);
            this.NotificationsPanel.Name = "NotificationsPanel";
            this.NotificationsPanel.Size = new System.Drawing.Size(200, 313);
            this.NotificationsPanel.TabIndex = 0;
            // 
            // notificationsTxtBox
            // 
            this.notificationsTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.notificationsTxtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.notificationsTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.notificationsTxtBox.Location = new System.Drawing.Point(8, 48);
            this.notificationsTxtBox.Multiline = true;
            this.notificationsTxtBox.Name = "notificationsTxtBox";
            this.notificationsTxtBox.Size = new System.Drawing.Size(180, 253);
            this.notificationsTxtBox.TabIndex = 15;
            // 
            // buttonPanel2
            // 
            this.buttonPanel2.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPanel2.Controls.Add(this.myBookingsButton);
            this.buttonPanel2.Location = new System.Drawing.Point(554, 141);
            this.buttonPanel2.Name = "buttonPanel2";
            this.buttonPanel2.Size = new System.Drawing.Size(200, 100);
            this.buttonPanel2.TabIndex = 3;
            // 
            // myBookingsButton
            // 
            this.myBookingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myBookingsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.myBookingsButton.Location = new System.Drawing.Point(0, 0);
            this.myBookingsButton.Name = "myBookingsButton";
            this.myBookingsButton.Size = new System.Drawing.Size(200, 100);
            this.myBookingsButton.TabIndex = 1;
            this.myBookingsButton.Text = "My Bookings";
            this.myBookingsButton.UseVisualStyleBackColor = true;
            this.myBookingsButton.Click += new System.EventHandler(this.myBookingsButton_Click);
            // 
            // buttonPanel3
            // 
            this.buttonPanel3.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPanel3.Controls.Add(this.quickGymButton);
            this.buttonPanel3.Location = new System.Drawing.Point(847, 141);
            this.buttonPanel3.Name = "buttonPanel3";
            this.buttonPanel3.Size = new System.Drawing.Size(200, 100);
            this.buttonPanel3.TabIndex = 3;
            // 
            // quickGymButton
            // 
            this.quickGymButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickGymButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quickGymButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.quickGymButton.Location = new System.Drawing.Point(0, 0);
            this.quickGymButton.Name = "quickGymButton";
            this.quickGymButton.Size = new System.Drawing.Size(200, 100);
            this.quickGymButton.TabIndex = 1;
            this.quickGymButton.Text = "Quick Gym";
            this.quickGymButton.UseVisualStyleBackColor = true;
            this.quickGymButton.Click += new System.EventHandler(this.quickGymButton_Click);
            // 
            // buttonPanel5
            // 
            this.buttonPanel5.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPanel5.Controls.Add(this.myAccountsButton);
            this.buttonPanel5.Location = new System.Drawing.Point(554, 318);
            this.buttonPanel5.Name = "buttonPanel5";
            this.buttonPanel5.Size = new System.Drawing.Size(200, 100);
            this.buttonPanel5.TabIndex = 3;
            // 
            // myAccountsButton
            // 
            this.myAccountsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myAccountsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.myAccountsButton.Location = new System.Drawing.Point(0, 0);
            this.myAccountsButton.Name = "myAccountsButton";
            this.myAccountsButton.Size = new System.Drawing.Size(200, 100);
            this.myAccountsButton.TabIndex = 1;
            this.myAccountsButton.Text = "My Account";
            this.myAccountsButton.UseVisualStyleBackColor = true;
            this.myAccountsButton.Click += new System.EventHandler(this.myAccountsButton_Click);
            // 
            // buttonPanel4
            // 
            this.buttonPanel4.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPanel4.Controls.Add(this.clubBookingsButton);
            this.buttonPanel4.Location = new System.Drawing.Point(265, 318);
            this.buttonPanel4.Name = "buttonPanel4";
            this.buttonPanel4.Size = new System.Drawing.Size(200, 100);
            this.buttonPanel4.TabIndex = 3;
            // 
            // clubBookingsButton
            // 
            this.clubBookingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clubBookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clubBookingsButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.clubBookingsButton.Location = new System.Drawing.Point(0, 0);
            this.clubBookingsButton.Name = "clubBookingsButton";
            this.clubBookingsButton.Size = new System.Drawing.Size(200, 100);
            this.clubBookingsButton.TabIndex = 1;
            this.clubBookingsButton.Text = "Club Bookings";
            this.clubBookingsButton.UseVisualStyleBackColor = true;
            this.clubBookingsButton.Click += new System.EventHandler(this.clubBookingsButton_Click);
            // 
            // buttonPanel1
            // 
            this.buttonPanel1.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPanel1.Controls.Add(this.bookNowButton);
            this.buttonPanel1.Location = new System.Drawing.Point(265, 141);
            this.buttonPanel1.Name = "buttonPanel1";
            this.buttonPanel1.Size = new System.Drawing.Size(200, 100);
            this.buttonPanel1.TabIndex = 3;
            // 
            // bookNowButton
            // 
            this.bookNowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookNowButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.bookNowButton.ForeColor = System.Drawing.Color.White;
            this.bookNowButton.Location = new System.Drawing.Point(0, 0);
            this.bookNowButton.Name = "bookNowButton";
            this.bookNowButton.Size = new System.Drawing.Size(200, 100);
            this.bookNowButton.TabIndex = 0;
            this.bookNowButton.Text = "Book Now!";
            this.bookNowButton.UseVisualStyleBackColor = true;
            this.bookNowButton.Click += new System.EventHandler(this.bookNowButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // busyTxt
            // 
            this.busyTxt.AutoSize = true;
            this.busyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.busyTxt.Font = new System.Drawing.Font("Lucida Handwriting", 13F, System.Drawing.FontStyle.Bold);
            this.busyTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.busyTxt.Location = new System.Drawing.Point(-1, 6);
            this.busyTxt.Name = "busyTxt";
            this.busyTxt.Size = new System.Drawing.Size(202, 23);
            this.busyTxt.TabIndex = 13;
            this.busyTxt.Text = "How busy are we?";
            // 
            // busyTxtBox1
            // 
            this.busyTxtBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.busyTxtBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.busyTxtBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.busyTxtBox1.ForeColor = System.Drawing.Color.Black;
            this.busyTxtBox1.Location = new System.Drawing.Point(39, 66);
            this.busyTxtBox1.Multiline = true;
            this.busyTxtBox1.Name = "busyTxtBox1";
            this.busyTxtBox1.ReadOnly = true;
            this.busyTxtBox1.Size = new System.Drawing.Size(123, 22);
            this.busyTxtBox1.TabIndex = 22;
            this.busyTxtBox1.TextChanged += new System.EventHandler(this.busyTxtBox_TextChanged);
            // 
            // notifcationTxt
            // 
            this.notifcationTxt.AutoSize = true;
            this.notifcationTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.notifcationTxt.Font = new System.Drawing.Font("Lucida Handwriting", 13F, System.Drawing.FontStyle.Bold);
            this.notifcationTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.notifcationTxt.Location = new System.Drawing.Point(-1, 7);
            this.notifcationTxt.Name = "notifcationTxt";
            this.notifcationTxt.Size = new System.Drawing.Size(154, 23);
            this.notifcationTxt.TabIndex = 13;
            this.notifcationTxt.Text = "Notifcations:";
            // 
            // busyTxtBox2
            // 
            this.busyTxtBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.busyTxtBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.busyTxtBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.busyTxtBox2.ForeColor = System.Drawing.Color.Black;
            this.busyTxtBox2.Location = new System.Drawing.Point(39, 132);
            this.busyTxtBox2.Multiline = true;
            this.busyTxtBox2.Name = "busyTxtBox2";
            this.busyTxtBox2.ReadOnly = true;
            this.busyTxtBox2.Size = new System.Drawing.Size(123, 22);
            this.busyTxtBox2.TabIndex = 22;
            this.busyTxtBox2.TextChanged += new System.EventHandler(this.busyTxtBox_TextChanged);
            // 
            // busyTxtBox3
            // 
            this.busyTxtBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.busyTxtBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.busyTxtBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.busyTxtBox3.ForeColor = System.Drawing.Color.Black;
            this.busyTxtBox3.Location = new System.Drawing.Point(39, 196);
            this.busyTxtBox3.Multiline = true;
            this.busyTxtBox3.Name = "busyTxtBox3";
            this.busyTxtBox3.ReadOnly = true;
            this.busyTxtBox3.Size = new System.Drawing.Size(123, 23);
            this.busyTxtBox3.TabIndex = 22;
            this.busyTxtBox3.TextChanged += new System.EventHandler(this.busyTxtBox_TextChanged);
            // 
            // centre1Label
            // 
            this.centre1Label.AutoSize = true;
            this.centre1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.centre1Label.Font = new System.Drawing.Font("Lucida Handwriting", 10F);
            this.centre1Label.ForeColor = System.Drawing.Color.White;
            this.centre1Label.Location = new System.Drawing.Point(29, 44);
            this.centre1Label.Name = "centre1Label";
            this.centre1Label.Size = new System.Drawing.Size(142, 19);
            this.centre1Label.TabIndex = 13;
            this.centre1Label.Text = "Riverdale Centre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Greenwood Centre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sunset Centre";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(838, 293);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1301, 624);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonPanel3);
            this.Controls.Add(this.buttonPanel1);
            this.Controls.Add(this.buttonPanel2);
            this.Controls.Add(this.buttonPanel4);
            this.Controls.Add(this.buttonPanel5);
            this.Controls.Add(this.busyButton);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.busyButton, 0);
            this.Controls.SetChildIndex(this.buttonPanel5, 0);
            this.Controls.SetChildIndex(this.buttonPanel4, 0);
            this.Controls.SetChildIndex(this.buttonPanel2, 0);
            this.Controls.SetChildIndex(this.buttonPanel1, 0);
            this.Controls.SetChildIndex(this.buttonPanel3, 0);
            this.Controls.SetChildIndex(this.topLeftIconPanel, 0);
            this.Controls.SetChildIndex(this.LeftSideBarPanel, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.topLeftIconPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topBarPanel.ResumeLayout(false);
            this.busyButton.ResumeLayout(false);
            this.busyButton.PerformLayout();
            this.NotificationsPanel.ResumeLayout(false);
            this.NotificationsPanel.PerformLayout();
            this.buttonPanel2.ResumeLayout(false);
            this.buttonPanel3.ResumeLayout(false);
            this.buttonPanel5.ResumeLayout(false);
            this.buttonPanel4.ResumeLayout(false);
            this.buttonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel busyButton;
        private System.Windows.Forms.Panel NotificationsPanel;
        private System.Windows.Forms.Panel buttonPanel2;
        private System.Windows.Forms.Panel buttonPanel3;
        private System.Windows.Forms.Panel buttonPanel5;
        private System.Windows.Forms.Panel buttonPanel4;
        private System.Windows.Forms.Panel buttonPanel1;
        private System.Windows.Forms.Button myBookingsButton;
        private System.Windows.Forms.Button quickGymButton;
        private System.Windows.Forms.Button myAccountsButton;
        private System.Windows.Forms.Button clubBookingsButton;
        private System.Windows.Forms.Button bookNowButton;
        private System.Windows.Forms.TableLayoutPanel topBarPanel;
        private System.Windows.Forms.Button contactUsButton;
        private System.Windows.Forms.Button PurposeButton;
        private System.Windows.Forms.Button offersButton;
        private System.Windows.Forms.Button dealsButton;
        private System.Windows.Forms.TextBox notificationsTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label busyTxt;
        private System.Windows.Forms.TextBox busyTxtBox1;
        private System.Windows.Forms.Label notifcationTxt;
        private System.Windows.Forms.TextBox busyTxtBox3;
        private System.Windows.Forms.TextBox busyTxtBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label centre1Label;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}