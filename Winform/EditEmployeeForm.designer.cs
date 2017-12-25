namespace Winform
{
    partial class EditEmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.genderLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.dobLbl = new System.Windows.Forms.Label();
            this.identityNumberTxt = new System.Windows.Forms.TextBox();
            this.identityNumberLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.firstNamLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.lastNamLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.femaleRb);
            this.panel1.Controls.Add(this.maleRb);
            this.panel1.Controls.Add(this.genderLbl);
            this.panel1.Controls.Add(this.phoneTxt);
            this.panel1.Controls.Add(this.phoneLbl);
            this.panel1.Controls.Add(this.DOBPicker);
            this.panel1.Controls.Add(this.dobLbl);
            this.panel1.Controls.Add(this.identityNumberTxt);
            this.panel1.Controls.Add(this.identityNumberLbl);
            this.panel1.Controls.Add(this.addressTxt);
            this.panel1.Controls.Add(this.addressLbl);
            this.panel1.Controls.Add(this.firstNameTxt);
            this.panel1.Controls.Add(this.firstNamLbl);
            this.panel1.Controls.Add(this.lastNameTxt);
            this.panel1.Controls.Add(this.lastNamLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 460);
            this.panel1.TabIndex = 24;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.Location = new System.Drawing.Point(297, 413);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 43;
            this.editBtn.Text = "Cập nhật";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // femaleRb
            // 
            this.femaleRb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(287, 341);
            this.femaleRb.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(43, 20);
            this.femaleRb.TabIndex = 42;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Nữ";
            this.femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            this.maleRb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(197, 340);
            this.maleRb.Margin = new System.Windows.Forms.Padding(4);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(55, 20);
            this.maleRb.TabIndex = 41;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Nam";
            this.maleRb.UseVisualStyleBackColor = true;
            // 
            // genderLbl
            // 
            this.genderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(40, 344);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(58, 16);
            this.genderLbl.TabIndex = 40;
            this.genderLbl.Text = "Giới tính:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTxt.Location = new System.Drawing.Point(197, 287);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(175, 22);
            this.phoneTxt.TabIndex = 39;
            // 
            // phoneLbl
            // 
            this.phoneLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(40, 290);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(89, 16);
            this.phoneLbl.TabIndex = 38;
            this.phoneLbl.Text = "Số điện thoại:";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBPicker.Location = new System.Drawing.Point(197, 233);
            this.DOBPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(175, 22);
            this.DOBPicker.TabIndex = 37;
            // 
            // dobLbl
            // 
            this.dobLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobLbl.AutoSize = true;
            this.dobLbl.Location = new System.Drawing.Point(40, 239);
            this.dobLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(71, 16);
            this.dobLbl.TabIndex = 36;
            this.dobLbl.Text = "Ngày sinh:";
            // 
            // identityNumberTxt
            // 
            this.identityNumberTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.identityNumberTxt.Location = new System.Drawing.Point(197, 187);
            this.identityNumberTxt.Margin = new System.Windows.Forms.Padding(4);
            this.identityNumberTxt.Name = "identityNumberTxt";
            this.identityNumberTxt.Size = new System.Drawing.Size(175, 22);
            this.identityNumberTxt.TabIndex = 35;
            // 
            // identityNumberLbl
            // 
            this.identityNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.identityNumberLbl.AutoSize = true;
            this.identityNumberLbl.Location = new System.Drawing.Point(40, 190);
            this.identityNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.identityNumberLbl.Name = "identityNumberLbl";
            this.identityNumberLbl.Size = new System.Drawing.Size(68, 16);
            this.identityNumberLbl.TabIndex = 34;
            this.identityNumberLbl.Text = "Số CMND";
            // 
            // addressTxt
            // 
            this.addressTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTxt.Location = new System.Drawing.Point(197, 131);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(175, 22);
            this.addressTxt.TabIndex = 33;
            // 
            // addressLbl
            // 
            this.addressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(40, 133);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(51, 16);
            this.addressLbl.TabIndex = 32;
            this.addressLbl.Text = "Địa chỉ:";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTxt.Location = new System.Drawing.Point(197, 81);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(175, 22);
            this.firstNameTxt.TabIndex = 31;
            // 
            // firstNamLbl
            // 
            this.firstNamLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNamLbl.AutoSize = true;
            this.firstNamLbl.Location = new System.Drawing.Point(40, 84);
            this.firstNamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNamLbl.Name = "firstNamLbl";
            this.firstNamLbl.Size = new System.Drawing.Size(35, 16);
            this.firstNamLbl.TabIndex = 30;
            this.firstNamLbl.Text = "Tên ";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTxt.Location = new System.Drawing.Point(197, 32);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(175, 22);
            this.lastNameTxt.TabIndex = 29;
            // 
            // lastNamLbl
            // 
            this.lastNamLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNamLbl.AutoSize = true;
            this.lastNamLbl.Location = new System.Drawing.Point(40, 35);
            this.lastNamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNamLbl.Name = "lastNamLbl";
            this.lastNamLbl.Size = new System.Drawing.Size(29, 16);
            this.lastNamLbl.TabIndex = 28;
            this.lastNamLbl.Text = "Họ ";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 460);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.TextBox identityNumberTxt;
        private System.Windows.Forms.Label identityNumberLbl;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label firstNamLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label lastNamLbl;
    }
}