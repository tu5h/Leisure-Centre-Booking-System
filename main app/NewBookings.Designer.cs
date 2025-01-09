namespace NEA___D1
{
    partial class NewBookings
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
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.availBookingsLabel = new System.Windows.Forms.Label();
            this.selectSiteCombo = new System.Windows.Forms.ComboBox();
            this.datePanel = new System.Windows.Forms.Panel();
            this.listOfAvailBookings = new System.Windows.Forms.ListView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typeOfBookingChecklist = new System.Windows.Forms.CheckedListBox();
            this.makeBookingButton = new System.Windows.Forms.Button();
            this.searchTypeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topBarPanel.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Location = new System.Drawing.Point(0, 70);
            this.LeftSideBarPanel.Size = new System.Drawing.Size(200, 607);
            // 
            // topBarPanel
            // 
            this.topBarPanel.Controls.Add(this.availBookingsLabel);
            this.topBarPanel.Controls.Add(this.topLeftIconPanel);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(1301, 70);
            this.topBarPanel.TabIndex = 1;
            this.topBarPanel.Controls.SetChildIndex(this.availBookingsLabel, 0);
            // 
            // availBookingsLabel
            // 
            this.availBookingsLabel.AutoSize = true;
            this.availBookingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.availBookingsLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availBookingsLabel.ForeColor = System.Drawing.Color.Ivory;
            this.availBookingsLabel.Location = new System.Drawing.Point(231, 9);
            this.availBookingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availBookingsLabel.Name = "availBookingsLabel";
            this.availBookingsLabel.Size = new System.Drawing.Size(445, 54);
            this.availBookingsLabel.TabIndex = 12;
            this.availBookingsLabel.Text = "Available Bookings";
            // 
            // selectSiteCombo
            // 
            this.selectSiteCombo.FormattingEnabled = true;
            this.selectSiteCombo.Location = new System.Drawing.Point(241, 111);
            this.selectSiteCombo.Name = "selectSiteCombo";
            this.selectSiteCombo.Size = new System.Drawing.Size(530, 21);
            this.selectSiteCombo.TabIndex = 5;
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.datePanel.Controls.Add(this.listOfAvailBookings);
            this.datePanel.Location = new System.Drawing.Point(811, 120);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(478, 545);
            this.datePanel.TabIndex = 3;
            // 
            // listOfAvailBookings
            // 
            this.listOfAvailBookings.HideSelection = false;
            this.listOfAvailBookings.Location = new System.Drawing.Point(-1, 17);
            this.listOfAvailBookings.Name = "listOfAvailBookings";
            this.listOfAvailBookings.Size = new System.Drawing.Size(479, 525);
            this.listOfAvailBookings.TabIndex = 1;
            this.listOfAvailBookings.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(812, 111);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(477, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // typeOfBookingChecklist
            // 
            this.typeOfBookingChecklist.FormattingEnabled = true;
            this.typeOfBookingChecklist.Location = new System.Drawing.Point(474, 159);
            this.typeOfBookingChecklist.Name = "typeOfBookingChecklist";
            this.typeOfBookingChecklist.Size = new System.Drawing.Size(297, 64);
            this.typeOfBookingChecklist.TabIndex = 4;
            // 
            // makeBookingButton
            // 
            this.makeBookingButton.BackColor = System.Drawing.Color.YellowGreen;
            this.makeBookingButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.makeBookingButton.Location = new System.Drawing.Point(474, 603);
            this.makeBookingButton.Name = "makeBookingButton";
            this.makeBookingButton.Size = new System.Drawing.Size(297, 59);
            this.makeBookingButton.TabIndex = 6;
            this.makeBookingButton.Text = "Make Booking";
            this.makeBookingButton.UseVisualStyleBackColor = false;
            this.makeBookingButton.Click += new System.EventHandler(this.makeBookingButton_Click);
            // 
            // searchTypeButton
            // 
            this.searchTypeButton.ForeColor = System.Drawing.Color.Black;
            this.searchTypeButton.Location = new System.Drawing.Point(638, 229);
            this.searchTypeButton.Name = "searchTypeButton";
            this.searchTypeButton.Size = new System.Drawing.Size(133, 26);
            this.searchTypeButton.TabIndex = 7;
            this.searchTypeButton.Text = "Search";
            this.searchTypeButton.UseVisualStyleBackColor = true;
            this.searchTypeButton.Click += new System.EventHandler(this.searchTypeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(474, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 68);
            this.panel1.TabIndex = 8;
            // 
            // NewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectSiteCombo);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.searchTypeButton);
            this.Controls.Add(this.makeBookingButton);
            this.Controls.Add(this.typeOfBookingChecklist);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.topBarPanel);
            this.Name = "NewBookings";
            this.Text = " ";
            this.Load += new System.EventHandler(this.NewBookings_Load);
            this.Controls.SetChildIndex(this.topBarPanel, 0);
            this.Controls.SetChildIndex(this.datePanel, 0);
            this.Controls.SetChildIndex(this.typeOfBookingChecklist, 0);
            this.Controls.SetChildIndex(this.LeftSideBarPanel, 0);
            this.Controls.SetChildIndex(this.makeBookingButton, 0);
            this.Controls.SetChildIndex(this.searchTypeButton, 0);
            this.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.Controls.SetChildIndex(this.selectSiteCombo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label availBookingsLabel;
        private System.Windows.Forms.Panel topLeftIconPanel;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckedListBox typeOfBookingChecklist;
        private System.Windows.Forms.ComboBox selectSiteCombo;
        private System.Windows.Forms.Button makeBookingButton;
        private System.Windows.Forms.Button searchTypeButton;
        private System.Windows.Forms.ListView listOfAvailBookings;
        private System.Windows.Forms.Panel panel1;
    }
}