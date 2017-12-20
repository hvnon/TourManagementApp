namespace Winform
{
    partial class AddGroupFeeForm
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
            this.feeTypLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.feeTypeCb = new System.Windows.Forms.ComboBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.addFeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feeTypLbl
            // 
            this.feeTypLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feeTypLbl.AutoSize = true;
            this.feeTypLbl.Location = new System.Drawing.Point(42, 23);
            this.feeTypLbl.Name = "feeTypLbl";
            this.feeTypLbl.Size = new System.Drawing.Size(46, 13);
            this.feeTypLbl.TabIndex = 0;
            this.feeTypLbl.Text = "Loại phí";
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(42, 69);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(44, 13);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Đơn giá";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(42, 121);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(34, 13);
            this.descriptionLbl.TabIndex = 2;
            this.descriptionLbl.Text = "Mô tả";
            // 
            // feeTypeCb
            // 
            this.feeTypeCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feeTypeCb.FormattingEnabled = true;
            this.feeTypeCb.Location = new System.Drawing.Point(106, 20);
            this.feeTypeCb.Name = "feeTypeCb";
            this.feeTypeCb.Size = new System.Drawing.Size(191, 21);
            this.feeTypeCb.TabIndex = 3;
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTxt.Location = new System.Drawing.Point(106, 66);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(191, 20);
            this.priceTxt.TabIndex = 4;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTxt.Location = new System.Drawing.Point(106, 118);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(191, 96);
            this.descriptionTxt.TabIndex = 5;
            this.descriptionTxt.Text = "";
            // 
            // addFeeBtn
            // 
            this.addFeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addFeeBtn.Location = new System.Drawing.Point(222, 250);
            this.addFeeBtn.Name = "addFeeBtn";
            this.addFeeBtn.Size = new System.Drawing.Size(75, 23);
            this.addFeeBtn.TabIndex = 6;
            this.addFeeBtn.Text = "Thêm";
            this.addFeeBtn.UseVisualStyleBackColor = true;
            this.addFeeBtn.Click += new System.EventHandler(this.addFeeBtn_Click);
            // 
            // AddGroupFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 296);
            this.Controls.Add(this.addFeeBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.feeTypeCb);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.feeTypLbl);
            this.MaximumSize = new System.Drawing.Size(374, 335);
            this.MinimumSize = new System.Drawing.Size(374, 335);
            this.Name = "AddGroupFeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chi phí cho đoàn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feeTypLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.ComboBox feeTypeCb;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.Button addFeeBtn;
    }
}