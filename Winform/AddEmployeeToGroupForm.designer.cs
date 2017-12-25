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
            this.addEmployeeToGroupPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roleLbl = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.addRoleBtn = new System.Windows.Forms.Button();
            this.addEmployeeToGroupPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeToGroupPanel
            // 
            this.addEmployeeToGroupPanel.ColumnCount = 1;
            this.addEmployeeToGroupPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addEmployeeToGroupPanel.Controls.Add(this.panel1, 0, 0);
            this.addEmployeeToGroupPanel.Controls.Add(this.panel2, 0, 1);
            this.addEmployeeToGroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployeeToGroupPanel.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeToGroupPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeToGroupPanel.Name = "addEmployeeToGroupPanel";
            this.addEmployeeToGroupPanel.RowCount = 2;
            this.addEmployeeToGroupPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.88612F));
            this.addEmployeeToGroupPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.11388F));
            this.addEmployeeToGroupPanel.Size = new System.Drawing.Size(872, 227);
            this.addEmployeeToGroupPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employeeTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 159);
            this.panel1.TabIndex = 0;
            // 
            // employeeTable
            // 
            this.employeeTable.AllowUserToAddRows = false;
            this.employeeTable.AllowUserToDeleteRows = false;
            this.employeeTable.AllowUserToResizeColumns = false;
            this.employeeTable.AllowUserToResizeRows = false;
            this.employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeTable.BackgroundColor = System.Drawing.Color.White;
            this.employeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ho,
            this.Ten,
            this.CMND,
            this.SDT,
            this.DiaChi,
            this.NgaySinh,
            this.GioiTinh});
            this.employeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTable.Location = new System.Drawing.Point(0, 0);
            this.employeeTable.Margin = new System.Windows.Forms.Padding(2);
            this.employeeTable.MultiSelect = false;
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.ReadOnly = true;
            this.employeeTable.RowHeadersVisible = false;
            this.employeeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTable.Size = new System.Drawing.Size(868, 159);
            this.employeeTable.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã NV";
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
            this.CMND.HeaderText = "CMND";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.roleLbl);
            this.panel2.Controls.Add(this.roleTxt);
            this.panel2.Controls.Add(this.addRoleBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 60);
            this.panel2.TabIndex = 1;
            // 
            // roleLbl
            // 
            this.roleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(303, 19);
            this.roleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(49, 17);
            this.roleLbl.TabIndex = 7;
            this.roleLbl.Text = "Vai trò:";
            // 
            // roleTxt
            // 
            this.roleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleTxt.Location = new System.Drawing.Point(361, 16);
            this.roleTxt.Margin = new System.Windows.Forms.Padding(2);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(157, 25);
            this.roleTxt.TabIndex = 10;
            // 
            // addRoleBtn
            // 
            this.addRoleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addRoleBtn.Location = new System.Drawing.Point(530, 13);
            this.addRoleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addRoleBtn.Name = "addRoleBtn";
            this.addRoleBtn.Size = new System.Drawing.Size(58, 28);
            this.addRoleBtn.TabIndex = 9;
            this.addRoleBtn.Text = "Thêm";
            this.addRoleBtn.UseVisualStyleBackColor = true;
            this.addRoleBtn.Click += new System.EventHandler(this.addRoleBtn_Click);
            // 
            // AddEmployeeToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 227);
            this.Controls.Add(this.addEmployeeToGroupPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddEmployeeToGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên vào đoàn";
            this.addEmployeeToGroupPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel addEmployeeToGroupPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Button addRoleBtn;
    }
}