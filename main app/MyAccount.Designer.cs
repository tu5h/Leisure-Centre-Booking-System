namespace NEA___D1
{
    partial class MyAccount
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.myAccountLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.phoneNumTxtBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Size = new System.Drawing.Size(200, 390);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(282, 111);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 19);
            this.usernameLabel.TabIndex = 30;
            this.usernameLabel.Text = "Username";
            // 
            // myAccountLabel
            // 
            this.myAccountLabel.AutoSize = true;
            this.myAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.myAccountLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAccountLabel.ForeColor = System.Drawing.Color.Ivory;
            this.myAccountLabel.Location = new System.Drawing.Point(216, 28);
            this.myAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myAccountLabel.Name = "myAccountLabel";
            this.myAccountLabel.Size = new System.Drawing.Size(287, 54);
            this.myAccountLabel.TabIndex = 31;
            this.myAccountLabel.Text = "My Account";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(315, 170);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 19);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.Location = new System.Drawing.Point(248, 230);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(118, 19);
            this.phoneNumLabel.TabIndex = 30;
            this.phoneNumLabel.Text = "Phone Number";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.usernameTxtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.usernameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTxtBox.Location = new System.Drawing.Point(397, 111);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.ReadOnly = true;
            this.usernameTxtBox.Size = new System.Drawing.Size(158, 27);
            this.usernameTxtBox.TabIndex = 32;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmailTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.EmailTxtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.EmailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.EmailTxtBox.Location = new System.Drawing.Point(397, 170);
            this.EmailTxtBox.Multiline = true;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(158, 27);
            this.EmailTxtBox.TabIndex = 32;
            // 
            // phoneNumTxtBox
            // 
            this.phoneNumTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneNumTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.phoneNumTxtBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.phoneNumTxtBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNumTxtBox.Location = new System.Drawing.Point(397, 230);
            this.phoneNumTxtBox.Multiline = true;
            this.phoneNumTxtBox.Name = "phoneNumTxtBox";
            this.phoneNumTxtBox.Size = new System.Drawing.Size(158, 27);
            this.phoneNumTxtBox.TabIndex = 32;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(466, 300);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 27);
            this.updateButton.TabIndex = 35;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.phoneNumTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.myAccountLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.Controls.SetChildIndex(this.topLeftIconPanel, 0);
            this.Controls.SetChildIndex(this.LeftSideBarPanel, 0);
            this.Controls.SetChildIndex(this.usernameLabel, 0);
            this.Controls.SetChildIndex(this.emailLabel, 0);
            this.Controls.SetChildIndex(this.phoneNumLabel, 0);
            this.Controls.SetChildIndex(this.myAccountLabel, 0);
            this.Controls.SetChildIndex(this.usernameTxtBox, 0);
            this.Controls.SetChildIndex(this.EmailTxtBox, 0);
            this.Controls.SetChildIndex(this.phoneNumTxtBox, 0);
            this.Controls.SetChildIndex(this.updateButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label myAccountLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox phoneNumTxtBox;
        private System.Windows.Forms.Button updateButton;
    }
}