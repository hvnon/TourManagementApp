namespace Winform
{
    partial class EditTourLocationForm
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
            this.addLocationPanel = new System.Windows.Forms.Panel();
            this.editLocationBtn = new System.Windows.Forms.Button();
            this.locationLbl = new System.Windows.Forms.Label();
            this.locationCb = new System.Windows.Forms.ComboBox();
            this.addLocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLocationPanel
            // 
            this.addLocationPanel.Controls.Add(this.editLocationBtn);
            this.addLocationPanel.Controls.Add(this.locationLbl);
            this.addLocationPanel.Controls.Add(this.locationCb);
            this.addLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.addLocationPanel.Name = "addLocationPanel";
            this.addLocationPanel.Size = new System.Drawing.Size(454, 111);
            this.addLocationPanel.TabIndex = 2;
            // 
            // editLocationBtn
            // 
            this.editLocationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editLocationBtn.Location = new System.Drawing.Point(294, 41);
            this.editLocationBtn.Name = "editLocationBtn";
            this.editLocationBtn.Size = new System.Drawing.Size(75, 23);
            this.editLocationBtn.TabIndex = 4;
            this.editLocationBtn.Text = "Cập nhật";
            this.editLocationBtn.UseVisualStyleBackColor = true;
            this.editLocationBtn.Click += new System.EventHandler(this.editLocationBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(70, 44);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(49, 13);
            this.locationLbl.TabIndex = 3;
            this.locationLbl.Text = "Đia điểm";
            // 
            // locationCb
            // 
            this.locationCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationCb.FormattingEnabled = true;
            this.locationCb.Location = new System.Drawing.Point(138, 41);
            this.locationCb.Name = "locationCb";
            this.locationCb.Size = new System.Drawing.Size(150, 21);
            this.locationCb.TabIndex = 2;
            // 
            // EditTourLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 111);
            this.Controls.Add(this.addLocationPanel);
            this.MaximumSize = new System.Drawing.Size(470, 150);
            this.MinimumSize = new System.Drawing.Size(470, 150);
            this.Name = "EditTourLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật địa điểm cho tour";
            this.addLocationPanel.ResumeLayout(false);
            this.addLocationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addLocationPanel;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox locationCb;
        private System.Windows.Forms.Button editLocationBtn;
    }
}