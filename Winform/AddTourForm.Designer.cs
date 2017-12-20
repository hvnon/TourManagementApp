namespace Winform
{
    partial class AddTourForm
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
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.nightTxt = new System.Windows.Forms.TextBox();
            this.dayTxt = new System.Windows.Forms.TextBox();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.districtCb = new System.Windows.Forms.ComboBox();
            this.cityCb = new System.Windows.Forms.ComboBox();
            this.tourTypeCb = new System.Windows.Forms.ComboBox();
            this.tourTypeLbl = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
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
            this.addLayoutPanel.Size = new System.Drawing.Size(634, 461);
            this.addLayoutPanel.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addPanel.Controls.Add(this.descriptionTxt);
            this.addPanel.Controls.Add(this.descriptionLbl);
            this.addPanel.Controls.Add(this.statusLbl);
            this.addPanel.Controls.Add(this.priceTxt);
            this.addPanel.Controls.Add(this.priceLbl);
            this.addPanel.Controls.Add(this.addBtn);
            this.addPanel.Controls.Add(this.nightTxt);
            this.addPanel.Controls.Add(this.dayTxt);
            this.addPanel.Controls.Add(this.statusCb);
            this.addPanel.Controls.Add(this.districtCb);
            this.addPanel.Controls.Add(this.cityCb);
            this.addPanel.Controls.Add(this.tourTypeCb);
            this.addPanel.Controls.Add(this.tourTypeLbl);
            this.addPanel.Controls.Add(this.durationLbl);
            this.addPanel.Controls.Add(this.fromLbl);
            this.addPanel.Controls.Add(this.nameTxt);
            this.addPanel.Controls.Add(this.codeTxt);
            this.addPanel.Controls.Add(this.nameLbl);
            this.addPanel.Controls.Add(this.codeLbl);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(3, 3);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(628, 455);
            this.addPanel.TabIndex = 20;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTxt.Location = new System.Drawing.Point(125, 242);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(445, 96);
            this.descriptionTxt.TabIndex = 25;
            this.descriptionTxt.Text = "";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(49, 242);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(34, 13);
            this.descriptionLbl.TabIndex = 24;
            this.descriptionLbl.Text = "Mô tả";
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(49, 182);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(55, 13);
            this.statusLbl.TabIndex = 23;
            this.statusLbl.Text = "Tình trạng";
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTxt.Location = new System.Drawing.Point(410, 182);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(160, 20);
            this.priceTxt.TabIndex = 20;
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(334, 184);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(23, 13);
            this.priceLbl.TabIndex = 19;
            this.priceLbl.Text = "Giá";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Location = new System.Drawing.Point(491, 403);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 27);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Tạo mới";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nightTxt
            // 
            this.nightTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nightTxt.Location = new System.Drawing.Point(491, 131);
            this.nightTxt.Name = "nightTxt";
            this.nightTxt.Size = new System.Drawing.Size(79, 20);
            this.nightTxt.TabIndex = 17;
            this.nightTxt.Text = "đêm";
            // 
            // dayTxt
            // 
            this.dayTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayTxt.Location = new System.Drawing.Point(410, 131);
            this.dayTxt.Name = "dayTxt";
            this.dayTxt.Size = new System.Drawing.Size(75, 20);
            this.dayTxt.TabIndex = 16;
            this.dayTxt.Text = "ngày";
            // 
            // statusCb
            // 
            this.statusCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Location = new System.Drawing.Point(125, 179);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(161, 21);
            this.statusCb.TabIndex = 15;
            // 
            // districtCb
            // 
            this.districtCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.districtCb.FormattingEnabled = true;
            this.districtCb.Location = new System.Drawing.Point(410, 77);
            this.districtCb.Name = "districtCb";
            this.districtCb.Size = new System.Drawing.Size(160, 21);
            this.districtCb.TabIndex = 13;
            // 
            // cityCb
            // 
            this.cityCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityCb.FormattingEnabled = true;
            this.cityCb.Location = new System.Drawing.Point(410, 28);
            this.cityCb.Name = "cityCb";
            this.cityCb.Size = new System.Drawing.Size(160, 21);
            this.cityCb.TabIndex = 12;
            this.cityCb.SelectionChangeCommitted += new System.EventHandler(this.cityCb_SelectionChangeCommitted);
            // 
            // tourTypeCb
            // 
            this.tourTypeCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourTypeCb.FormattingEnabled = true;
            this.tourTypeCb.Location = new System.Drawing.Point(125, 129);
            this.tourTypeCb.Name = "tourTypeCb";
            this.tourTypeCb.Size = new System.Drawing.Size(161, 21);
            this.tourTypeCb.TabIndex = 11;
            // 
            // tourTypeLbl
            // 
            this.tourTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourTypeLbl.AutoSize = true;
            this.tourTypeLbl.Location = new System.Drawing.Point(49, 132);
            this.tourTypeLbl.Name = "tourTypeLbl";
            this.tourTypeLbl.Size = new System.Drawing.Size(48, 13);
            this.tourTypeLbl.TabIndex = 10;
            this.tourTypeLbl.Text = "Loại tour";
            // 
            // durationLbl
            // 
            this.durationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationLbl.AutoSize = true;
            this.durationLbl.Location = new System.Drawing.Point(334, 133);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(46, 13);
            this.durationLbl.TabIndex = 8;
            this.durationLbl.Text = "Số ngày";
            // 
            // fromLbl
            // 
            this.fromLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(334, 31);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(70, 13);
            this.fromLbl.TabIndex = 6;
            this.fromLbl.Text = "Nơi xuất phát";
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxt.Location = new System.Drawing.Point(125, 78);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(161, 20);
            this.nameTxt.TabIndex = 4;
            // 
            // codeTxt
            // 
            this.codeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTxt.Location = new System.Drawing.Point(125, 29);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.ReadOnly = true;
            this.codeTxt.Size = new System.Drawing.Size(161, 20);
            this.codeTxt.TabIndex = 3;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(49, 81);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Tên tour";
            // 
            // codeLbl
            // 
            this.codeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(49, 32);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(43, 13);
            this.codeLbl.TabIndex = 1;
            this.codeLbl.Text = "Mã tour";
            // 
            // AddTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.addLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "AddTourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tour mới";
            this.addLayoutPanel.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addLayoutPanel;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nightTxt;
        private System.Windows.Forms.TextBox dayTxt;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.ComboBox districtCb;
        private System.Windows.Forms.ComboBox cityCb;
        private System.Windows.Forms.ComboBox tourTypeCb;
        private System.Windows.Forms.Label tourTypeLbl;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.RichTextBox descriptionTxt;
    }
}