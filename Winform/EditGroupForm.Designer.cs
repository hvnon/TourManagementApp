namespace Winform
{
    partial class EditGroupForm
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
            this.addLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.policyTxt = new System.Windows.Forms.RichTextBox();
            this.policyLbl = new System.Windows.Forms.Label();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dropLocationTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pickupLocationTxt = new System.Windows.Forms.TextBox();
            this.pickupLocationLbl = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.addLayoutPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLayoutPanel
            // 
            this.addLayoutPanel.ColumnCount = 1;
            this.addLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addLayoutPanel.Controls.Add(this.addPanel, 0, 0);
            this.addLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.addLayoutPanel.Name = "addLayoutPanel";
            this.addLayoutPanel.RowCount = 1;
            this.addLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addLayoutPanel.Size = new System.Drawing.Size(634, 551);
            this.addLayoutPanel.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addPanel.Controls.Add(this.policyTxt);
            this.addPanel.Controls.Add(this.policyLbl);
            this.addPanel.Controls.Add(this.endDateLbl);
            this.addPanel.Controls.Add(this.endDatePicker);
            this.addPanel.Controls.Add(this.startDateLbl);
            this.addPanel.Controls.Add(this.startDatePicker);
            this.addPanel.Controls.Add(this.dropLocationTxt);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.pickupLocationTxt);
            this.addPanel.Controls.Add(this.pickupLocationLbl);
            this.addPanel.Controls.Add(this.descriptionTxt);
            this.addPanel.Controls.Add(this.descriptionLbl);
            this.addPanel.Controls.Add(this.editBtn);
            this.addPanel.Controls.Add(this.nameTxt);
            this.addPanel.Controls.Add(this.codeTxt);
            this.addPanel.Controls.Add(this.nameLbl);
            this.addPanel.Controls.Add(this.codeLbl);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(3, 3);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(628, 545);
            this.addPanel.TabIndex = 20;
            // 
            // policyTxt
            // 
            this.policyTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.policyTxt.Location = new System.Drawing.Point(115, 351);
            this.policyTxt.Name = "policyTxt";
            this.policyTxt.Size = new System.Drawing.Size(454, 96);
            this.policyTxt.TabIndex = 35;
            this.policyTxt.Text = "";
            // 
            // policyLbl
            // 
            this.policyLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.policyLbl.AutoSize = true;
            this.policyLbl.Location = new System.Drawing.Point(39, 351);
            this.policyLbl.Name = "policyLbl";
            this.policyLbl.Size = new System.Drawing.Size(62, 13);
            this.policyLbl.TabIndex = 34;
            this.policyLbl.Text = "Chính sách";
            // 
            // endDateLbl
            // 
            this.endDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(332, 91);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(47, 13);
            this.endDateLbl.TabIndex = 33;
            this.endDateLbl.Text = "Ngày về";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDatePicker.Location = new System.Drawing.Point(409, 89);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(160, 20);
            this.endDatePicker.TabIndex = 32;
            // 
            // startDateLbl
            // 
            this.startDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(39, 92);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(44, 13);
            this.startDateLbl.TabIndex = 31;
            this.startDateLbl.Text = "Ngày đi";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDatePicker.Location = new System.Drawing.Point(115, 92);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(160, 20);
            this.startDatePicker.TabIndex = 30;
            // 
            // dropLocationTxt
            // 
            this.dropLocationTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropLocationTxt.Location = new System.Drawing.Point(408, 159);
            this.dropLocationTxt.Name = "dropLocationTxt";
            this.dropLocationTxt.Size = new System.Drawing.Size(161, 20);
            this.dropLocationTxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Địa điểm thả";
            // 
            // pickupLocationTxt
            // 
            this.pickupLocationTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickupLocationTxt.Location = new System.Drawing.Point(115, 159);
            this.pickupLocationTxt.Name = "pickupLocationTxt";
            this.pickupLocationTxt.Size = new System.Drawing.Size(161, 20);
            this.pickupLocationTxt.TabIndex = 27;
            // 
            // pickupLocationLbl
            // 
            this.pickupLocationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickupLocationLbl.AutoSize = true;
            this.pickupLocationLbl.Location = new System.Drawing.Point(39, 162);
            this.pickupLocationLbl.Name = "pickupLocationLbl";
            this.pickupLocationLbl.Size = new System.Drawing.Size(73, 13);
            this.pickupLocationLbl.TabIndex = 26;
            this.pickupLocationLbl.Text = "Địa điêm rước";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTxt.Location = new System.Drawing.Point(115, 221);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(454, 96);
            this.descriptionTxt.TabIndex = 25;
            this.descriptionTxt.Text = "";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(39, 221);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(56, 13);
            this.descriptionLbl.TabIndex = 24;
            this.descriptionLbl.Text = "Hành trình";
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.Location = new System.Drawing.Point(490, 490);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(79, 27);
            this.editBtn.TabIndex = 18;
            this.editBtn.Text = "Cập nhật";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxt.Location = new System.Drawing.Point(409, 25);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(161, 20);
            this.nameTxt.TabIndex = 4;
            // 
            // codeTxt
            // 
            this.codeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTxt.Location = new System.Drawing.Point(115, 25);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.ReadOnly = true;
            this.codeTxt.Size = new System.Drawing.Size(161, 20);
            this.codeTxt.TabIndex = 3;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(333, 28);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(54, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Tên đoàn";
            // 
            // codeLbl
            // 
            this.codeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(39, 28);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(50, 13);
            this.codeLbl.TabIndex = 1;
            this.codeLbl.Text = "Mã đoàn";
            // 
            // EditGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 551);
            this.Controls.Add(this.addLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(650, 590);
            this.MinimumSize = new System.Drawing.Size(650, 590);
            this.Name = "EditGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin đoàn";
            this.addLayoutPanel.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addLayoutPanel;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.RichTextBox policyTxt;
        private System.Windows.Forms.Label policyLbl;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.TextBox dropLocationTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pickupLocationTxt;
        private System.Windows.Forms.Label pickupLocationLbl;
    }
}