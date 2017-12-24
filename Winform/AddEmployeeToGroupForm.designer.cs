namespace Winform
{
    partial class AddEmployeeToGroupForm
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
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtmanhom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AllowUserToAddRows = false;
            this.dtgvNhanVien.AllowUserToDeleteRows = false;
            this.dtgvNhanVien.AllowUserToResizeColumns = false;
            this.dtgvNhanVien.AllowUserToResizeRows = false;
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dtgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ho,
            this.Ten,
            this.CMND,
            this.SDT,
            this.DiaChi,
            this.NgaySinh,
            this.GioiTinh});
            this.dtgvNhanVien.Location = new System.Drawing.Point(12, 12);
            this.dtgvNhanVien.MultiSelect = false;
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.ReadOnly = true;
            this.dtgvNhanVien.RowHeadersVisible = false;
            this.dtgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhanVien.Size = new System.Drawing.Size(829, 181);
            this.dtgvNhanVien.TabIndex = 1;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ho
            // 
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "Số chứng minh nhân dân";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OKClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vai trò:";
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Location = new System.Drawing.Point(76, 204);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(201, 29);
            this.txtVaiTro.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(642, 212);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(18, 29);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtmanhom
            // 
            this.txtmanhom.Location = new System.Drawing.Point(622, 212);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(14, 29);
            this.txtmanhom.TabIndex = 8;
            // 
            // AddEmployeeToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 281);
            this.Controls.Add(this.txtmanhom);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvNhanVien);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddEmployeeToGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên vào";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtmanhom;
    }
}