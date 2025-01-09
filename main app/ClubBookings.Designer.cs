namespace NEA___D1
{
    partial class ClubBookings
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
            this.frequencyTxtBox = new System.Windows.Forms.TextBox();
            this.activityCombo = new System.Windows.Forms.ComboBox();
            this.activityStartDateBox = new System.Windows.Forms.TextBox();
            this.makeBookingButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.timeCombo = new System.Windows.Forms.ComboBox();
            this.selectSiteCombo = new System.Windows.Forms.ComboBox();
            this.clubBookingsLabel = new System.Windows.Forms.Label();
            this.leisureCentreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfWeeksLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Size = new System.Drawing.Size(200, 435);
            // 
            // frequencyTxtBox
            // 
            this.frequencyTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.frequencyTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.frequencyTxtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.frequencyTxtBox.ForeColor = System.Drawing.Color.Black;
            this.frequencyTxtBox.Location = new System.Drawing.Point(368, 245);
            this.frequencyTxtBox.Multiline = true;
            this.frequencyTxtBox.Name = "frequencyTxtBox";
            this.frequencyTxtBox.Size = new System.Drawing.Size(123, 27);
            this.frequencyTxtBox.TabIndex = 21;
            this.frequencyTxtBox.Text = "NUMBER OF WEEKS";
            this.frequencyTxtBox.Leave += new System.EventHandler(this.frequencyTxtBox_Leave);
            // 
            // activityCombo
            // 
            this.activityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityCombo.FormattingEnabled = true;
            this.activityCombo.Location = new System.Drawing.Point(368, 311);
            this.activityCombo.Name = "activityCombo";
            this.activityCombo.Size = new System.Drawing.Size(175, 24);
            this.activityCombo.TabIndex = 22;
            //this.activityCombo.SelectedIndexChanged += new System.EventHandler(this.activityCombo_SelectedIndexChanged);
            // 
            // activityStartDateBox
            // 
            this.activityStartDateBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.activityStartDateBox.BackColor = System.Drawing.Color.FloralWhite;
            this.activityStartDateBox.Enabled = false;
            this.activityStartDateBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.activityStartDateBox.ForeColor = System.Drawing.Color.Black;
            this.activityStartDateBox.Location = new System.Drawing.Point(629, 269);
            this.activityStartDateBox.Multiline = true;
            this.activityStartDateBox.Name = "activityStartDateBox";
            this.activityStartDateBox.Size = new System.Drawing.Size(123, 27);
            this.activityStartDateBox.TabIndex = 21;
            this.activityStartDateBox.Text = "ACTIVITY START DATE";
            // 
            // makeBookingButton
            // 
            this.makeBookingButton.BackColor = System.Drawing.Color.YellowGreen;
            this.makeBookingButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.makeBookingButton.Location = new System.Drawing.Point(579, 329);
            this.makeBookingButton.Name = "makeBookingButton";
            this.makeBookingButton.Size = new System.Drawing.Size(182, 59);
            this.makeBookingButton.TabIndex = 23;
            this.makeBookingButton.Text = "Make Booking";
            this.makeBookingButton.UseVisualStyleBackColor = false;
            this.makeBookingButton.Click += new System.EventHandler(this.makeBookingButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.FloralWhite;
            this.monthCalendar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.monthCalendar.Location = new System.Drawing.Point(569, 95);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 20;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // timeCombo
            // 
            this.timeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCombo.FormattingEnabled = true;
            this.timeCombo.Location = new System.Drawing.Point(368, 175);
            this.timeCombo.Name = "timeCombo";
            this.timeCombo.Size = new System.Drawing.Size(97, 26);
            this.timeCombo.TabIndex = 25;
            this.timeCombo.SelectedIndexChanged += new System.EventHandler(this.timeCombo_SelectedIndexChanged);
            // 
            // selectSiteCombo
            // 
            this.selectSiteCombo.FormattingEnabled = true;
            this.selectSiteCombo.Location = new System.Drawing.Point(368, 116);
            this.selectSiteCombo.Name = "selectSiteCombo";
            this.selectSiteCombo.Size = new System.Drawing.Size(175, 21);
            this.selectSiteCombo.TabIndex = 26;
            // 
            // clubBookingsLabel
            // 
            this.clubBookingsLabel.AutoSize = true;
            this.clubBookingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.clubBookingsLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubBookingsLabel.ForeColor = System.Drawing.Color.Ivory;
            this.clubBookingsLabel.Location = new System.Drawing.Point(225, 9);
            this.clubBookingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clubBookingsLabel.Name = "clubBookingsLabel";
            this.clubBookingsLabel.Size = new System.Drawing.Size(345, 54);
            this.clubBookingsLabel.TabIndex = 27;
            this.clubBookingsLabel.Text = "Club Bookings";
            // 
            // leisureCentreLabel
            // 
            this.leisureCentreLabel.AutoSize = true;
            this.leisureCentreLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leisureCentreLabel.Location = new System.Drawing.Point(237, 114);
            this.leisureCentreLabel.Name = "leisureCentreLabel";
            this.leisureCentreLabel.Size = new System.Drawing.Size(117, 19);
            this.leisureCentreLabel.TabIndex = 28;
            this.leisureCentreLabel.Text = "Leisure Centre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Time";
            // 
            // numOfWeeksLabel
            // 
            this.numOfWeeksLabel.AutoSize = true;
            this.numOfWeeksLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfWeeksLabel.Location = new System.Drawing.Point(214, 234);
            this.numOfWeeksLabel.Name = "numOfWeeksLabel";
            this.numOfWeeksLabel.Size = new System.Drawing.Size(140, 38);
            this.numOfWeeksLabel.TabIndex = 28;
            this.numOfWeeksLabel.Text = "Number of weeks \r\nto book (1 - 4)\r\n";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(235, 316);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(119, 19);
            this.activityLabel.TabIndex = 28;
            this.activityLabel.Text = "Choose Activity";
            // 
            // ClubBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 435);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.numOfWeeksLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leisureCentreLabel);
            this.Controls.Add(this.clubBookingsLabel);
            this.Controls.Add(this.selectSiteCombo);
            this.Controls.Add(this.timeCombo);
            this.Controls.Add(this.makeBookingButton);
            this.Controls.Add(this.activityCombo);
            this.Controls.Add(this.frequencyTxtBox);
            this.Controls.Add(this.activityStartDateBox);
            this.Controls.Add(this.monthCalendar);
            this.Name = "ClubBookings";
            this.Text = "ClubBookings";
            this.Load += new System.EventHandler(this.ClubBookings_Load);
            this.Controls.SetChildIndex(this.monthCalendar, 0);
            this.Controls.SetChildIndex(this.activityStartDateBox, 0);
            this.Controls.SetChildIndex(this.frequencyTxtBox, 0);
            this.Controls.SetChildIndex(this.activityCombo, 0);
            this.Controls.SetChildIndex(this.makeBookingButton, 0);
            this.Controls.SetChildIndex(this.topLeftIconPanel, 0);
            this.Controls.SetChildIndex(this.LeftSideBarPanel, 0);
            this.Controls.SetChildIndex(this.timeCombo, 0);
            this.Controls.SetChildIndex(this.selectSiteCombo, 0);
            this.Controls.SetChildIndex(this.clubBookingsLabel, 0);
            this.Controls.SetChildIndex(this.leisureCentreLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.numOfWeeksLabel, 0);
            this.Controls.SetChildIndex(this.activityLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox frequencyTxtBox;
        private System.Windows.Forms.ComboBox activityCombo;
        private System.Windows.Forms.TextBox activityStartDateBox;
        private System.Windows.Forms.Button makeBookingButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox timeCombo;
        private System.Windows.Forms.ComboBox selectSiteCombo;
        private System.Windows.Forms.Label clubBookingsLabel;
        private System.Windows.Forms.Label leisureCentreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numOfWeeksLabel;
        private System.Windows.Forms.Label activityLabel;
    }
}