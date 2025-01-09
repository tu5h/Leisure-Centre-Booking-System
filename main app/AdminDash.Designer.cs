namespace NEA___D1
{
    partial class AdminDash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminPanelLabel = new System.Windows.Forms.Label();
            this.sendAlertTxt = new System.Windows.Forms.Label();
            this.alertBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.usersLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.usersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.createNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentsLabel = new System.Windows.Forms.Label();
            this.updateTxtBox = new System.Windows.Forms.TextBox();
            this.ApartmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topLeftIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Size = new System.Drawing.Size(15, 868);
            this.LeftSideBarPanel.Visible = false;
            // 
            // topLeftIconPanel
            // 
            this.topLeftIconPanel.Controls.Add(this.pictureBox1);
            // 
            // adminPanelLabel
            // 
            this.adminPanelLabel.AutoSize = true;
            this.adminPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminPanelLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelLabel.ForeColor = System.Drawing.Color.Ivory;
            this.adminPanelLabel.Location = new System.Drawing.Point(216, 9);
            this.adminPanelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminPanelLabel.Name = "adminPanelLabel";
            this.adminPanelLabel.Size = new System.Drawing.Size(301, 54);
            this.adminPanelLabel.TabIndex = 13;
            this.adminPanelLabel.Text = "Admin Panel";
            // 
            // sendAlertTxt
            // 
            this.sendAlertTxt.AutoSize = true;
            this.sendAlertTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.sendAlertTxt.Font = new System.Drawing.Font("Lucida Handwriting", 13F, System.Drawing.FontStyle.Bold);
            this.sendAlertTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sendAlertTxt.Location = new System.Drawing.Point(200, 110);
            this.sendAlertTxt.Name = "sendAlertTxt";
            this.sendAlertTxt.Size = new System.Drawing.Size(134, 23);
            this.sendAlertTxt.TabIndex = 14;
            this.sendAlertTxt.Text = "Send Alert!";
            // 
            // alertBox
            // 
            this.alertBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.alertBox.BackColor = System.Drawing.Color.FloralWhite;
            this.alertBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.alertBox.ForeColor = System.Drawing.Color.Black;
            this.alertBox.Location = new System.Drawing.Point(204, 137);
            this.alertBox.Multiline = true;
            this.alertBox.Name = "alertBox";
            this.alertBox.Size = new System.Drawing.Size(478, 118);
            this.alertBox.TabIndex = 15;
            this.alertBox.Text = "Send Message";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(589, 261);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(93, 26);
            this.sendButton.TabIndex = 16;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.usersLabel.Font = new System.Drawing.Font("Lucida Handwriting", 13F, System.Drawing.FontStyle.Bold);
            this.usersLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usersLabel.Location = new System.Drawing.Point(43, 288);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(74, 23);
            this.usersLabel.TabIndex = 17;
            this.usersLabel.Text = "Users:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Username,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber,
            this.HouseName,
            this.Address1,
            this.Town,
            this.Postcode,
            this.Address2,
            this.ApartmentNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.dataGridView.Location = new System.Drawing.Point(47, 324);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1304, 186);
            this.dataGridView.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FloralWhite;
            this.monthCalendar1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.monthCalendar1.Location = new System.Drawing.Point(726, 73);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // usersChart
            // 
            this.usersChart.BackColor = System.Drawing.Color.FloralWhite;
            chartArea1.Name = "ChartArea1";
            this.usersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.usersChart.Legends.Add(legend1);
            this.usersChart.Location = new System.Drawing.Point(991, 73);
            this.usersChart.Name = "usersChart";
            this.usersChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.usersChart.Series.Add(series1);
            this.usersChart.Size = new System.Drawing.Size(325, 162);
            this.usersChart.TabIndex = 20;
            this.usersChart.Text = "chart1";
            this.usersChart.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(213, 526);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 26);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBox.BackColor = System.Drawing.Color.FloralWhite;
            this.searchBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.Location = new System.Drawing.Point(47, 527);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(160, 27);
            this.searchBox.TabIndex = 15;
            this.searchBox.Text = "Search";
            // 
            // createNewButton
            // 
            this.createNewButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.createNewButton.ForeColor = System.Drawing.Color.Black;
            this.createNewButton.Location = new System.Drawing.Point(1026, 574);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(89, 27);
            this.createNewButton.TabIndex = 22;
            this.createNewButton.Text = "Create new";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(1026, 527);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 27);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.refreshButton.ForeColor = System.Drawing.Color.Black;
            this.refreshButton.Location = new System.Drawing.Point(1192, 574);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(89, 27);
            this.refreshButton.TabIndex = 22;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshNewButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.dataGridViewTextBoxColumn1,
            this.BookingID,
            this.PaymentDate,
            this.Amount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.dataGridView1.Location = new System.Drawing.Point(47, 653);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 186);
            this.dataGridView1.TabIndex = 18;
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.AutoSize = true;
            this.paymentsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.paymentsLabel.Font = new System.Drawing.Font("Lucida Handwriting", 13F, System.Drawing.FontStyle.Bold);
            this.paymentsLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.paymentsLabel.Location = new System.Drawing.Point(43, 617);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(226, 23);
            this.paymentsLabel.TabIndex = 17;
            this.paymentsLabel.Text = "Payments Recieved:";
            // 
            // updateTxtBox
            // 
            this.updateTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.updateTxtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.updateTxtBox.ForeColor = System.Drawing.Color.Black;
            this.updateTxtBox.Location = new System.Drawing.Point(1121, 527);
            this.updateTxtBox.Multiline = true;
            this.updateTxtBox.Name = "updateTxtBox";
            this.updateTxtBox.Size = new System.Drawing.Size(160, 27);
            this.updateTxtBox.TabIndex = 15;
            this.updateTxtBox.Text = "Update";
            // 
            // ApartmentNo
            // 
            this.ApartmentNo.HeaderText = "ApartNo";
            this.ApartmentNo.Name = "ApartmentNo";
            // 
            // Address2
            // 
            this.Address2.HeaderText = "Address2";
            this.Address2.Name = "Address2";
            // 
            // Postcode
            // 
            this.Postcode.HeaderText = "Postcode";
            this.Postcode.Name = "Postcode";
            // 
            // Town
            // 
            this.Town.HeaderText = "Town";
            this.Town.Name = "Town";
            // 
            // Address1
            // 
            this.Address1.HeaderText = "Address1";
            this.Address1.Name = "Address1";
            // 
            // HouseName
            // 
            this.HouseName.HeaderText = "HouseName";
            this.HouseName.Name = "HouseName";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "PaymentID";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "LoginID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BookingID
            // 
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "PaymentDate";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1382, 868);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createNewButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.usersChart);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.paymentsLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.updateTxtBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.alertBox);
            this.Controls.Add(this.sendAlertTxt);
            this.Controls.Add(this.adminPanelLabel);
            this.Name = "AdminDash";
            this.Text = "AdminDash";
            this.Load += new System.EventHandler(this.AdminDash_Load);
            this.Controls.SetChildIndex(this.adminPanelLabel, 0);
            this.Controls.SetChildIndex(this.sendAlertTxt, 0);
            this.Controls.SetChildIndex(this.alertBox, 0);
            this.Controls.SetChildIndex(this.searchBox, 0);
            this.Controls.SetChildIndex(this.updateTxtBox, 0);
            this.Controls.SetChildIndex(this.sendButton, 0);
            this.Controls.SetChildIndex(this.usersLabel, 0);
            this.Controls.SetChildIndex(this.paymentsLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.usersChart, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.createNewButton, 0);
            this.Controls.SetChildIndex(this.updateButton, 0);
            this.Controls.SetChildIndex(this.refreshButton, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.Controls.SetChildIndex(this.LeftSideBarPanel, 0);
            this.Controls.SetChildIndex(this.topLeftIconPanel, 0);
            this.topLeftIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminPanelLabel;
        private System.Windows.Forms.Label sendAlertTxt;
        private System.Windows.Forms.TextBox alertBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart usersChart;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label paymentsLabel;
        private System.Windows.Forms.TextBox updateTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}