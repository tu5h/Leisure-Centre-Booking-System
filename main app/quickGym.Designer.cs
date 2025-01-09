namespace NEA___D1
{
    partial class quickGym
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
            this.selectSiteCombo = new System.Windows.Forms.ComboBox();
            this.quickGymLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Size = new System.Drawing.Size(200, 450);
            // 
            // selectSiteCombo
            // 
            this.selectSiteCombo.FormattingEnabled = true;
            this.selectSiteCombo.Location = new System.Drawing.Point(324, 97);
            this.selectSiteCombo.Name = "selectSiteCombo";
            this.selectSiteCombo.Size = new System.Drawing.Size(226, 21);
            this.selectSiteCombo.TabIndex = 27;
            // 
            // quickGymLabel
            // 
            this.quickGymLabel.AutoSize = true;
            this.quickGymLabel.BackColor = System.Drawing.Color.Transparent;
            this.quickGymLabel.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickGymLabel.ForeColor = System.Drawing.Color.Ivory;
            this.quickGymLabel.Location = new System.Drawing.Point(221, 19);
            this.quickGymLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quickGymLabel.Name = "quickGymLabel";
            this.quickGymLabel.Size = new System.Drawing.Size(265, 54);
            this.quickGymLabel.TabIndex = 28;
            this.quickGymLabel.Text = "Quick Gym";
            // 
            // quickGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quickGymLabel);
            this.Controls.Add(this.selectSiteCombo);
            this.Name = "quickGym";
            this.Text = "quickGym";
            this.Load += new System.EventHandler(this.quickGym_Load);
            this.Controls.SetChildIndex(this.topLeftIconPanel, 0);
            this.Controls.SetChildIndex(this.LeftSideBarPanel, 0);
            this.Controls.SetChildIndex(this.selectSiteCombo, 0);
            this.Controls.SetChildIndex(this.quickGymLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectSiteCombo;
        private System.Windows.Forms.Label quickGymLabel;
    }
}