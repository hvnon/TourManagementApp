namespace Winform
{
    partial class GroupDetailForm
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customerContainerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerTablePanel = new System.Windows.Forms.Panel();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerActionPanel = new System.Windows.Forms.Panel();
            this.refreshCustomerBtn = new System.Windows.Forms.PictureBox();
            this.customerSearchPanel = new System.Windows.Forms.Panel();
            this.searchCustomerBtn = new System.Windows.Forms.Button();
            this.indentityNumberTxt = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.identityNumberLbl = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.addEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.refreshEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.findroleBtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.MaVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.feeTableContainerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.feeTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeActionPanel = new System.Windows.Forms.Panel();
            this.refreshFeeBtn = new System.Windows.Forms.PictureBox();
            this.addFeeBtn = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.customerContainerPanel.SuspendLayout();
            this.customerTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.customerActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCustomerBtn)).BeginInit();
            this.customerSearchPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteEmployeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshEmployeeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.feeTableContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeTable)).BeginInit();
            this.feeActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshFeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFeeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customerContainerPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customerContainerPanel
            // 
            this.customerContainerPanel.ColumnCount = 1;
            this.customerContainerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerContainerPanel.Controls.Add(this.customerTablePanel, 0, 2);
            this.customerContainerPanel.Controls.Add(this.customerActionPanel, 0, 1);
            this.customerContainerPanel.Controls.Add(this.customerSearchPanel, 0, 0);
            this.customerContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.customerContainerPanel.Name = "customerContainerPanel";
            this.customerContainerPanel.RowCount = 3;
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31231F));
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.68769F));
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customerContainerPanel.Size = new System.Drawing.Size(802, 401);
            this.customerContainerPanel.TabIndex = 1;
            // 
            // customerTablePanel
            // 
            this.customerTablePanel.Controls.Add(this.customerTable);
            this.customerTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTablePanel.Location = new System.Drawing.Point(3, 111);
            this.customerTablePanel.Name = "customerTablePanel";
            this.customerTablePanel.Size = new System.Drawing.Size(796, 287);
            this.customerTablePanel.TabIndex = 0;
            // 
            // customerTable
            // 
            this.customerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Code,
            this.LastName,
            this.FirstName,
            this.IdentityNumber,
            this.Phone,
            this.Address,
            this.DOB,
            this.Gender});
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTable.Location = new System.Drawing.Point(0, 0);
            this.customerTable.Name = "customerTable";
            this.customerTable.Size = new System.Drawing.Size(796, 287);
            this.customerTable.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Code
            // 
            this.Code.HeaderText = "Mã KH";
            this.Code.Name = "Code";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Họ";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Tên";
            this.FirstName.Name = "FirstName";
            // 
            // IdentityNumber
            // 
            this.IdentityNumber.HeaderText = "CMND";
            this.IdentityNumber.Name = "IdentityNumber";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Ngày sinh";
            this.DOB.Name = "DOB";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            // 
            // customerActionPanel
            // 
            this.customerActionPanel.Controls.Add(this.refreshCustomerBtn);
            this.customerActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerActionPanel.Location = new System.Drawing.Point(3, 71);
            this.customerActionPanel.Name = "customerActionPanel";
            this.customerActionPanel.Size = new System.Drawing.Size(796, 34);
            this.customerActionPanel.TabIndex = 1;
            // 
            // refreshCustomerBtn
            // 
            this.refreshCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshCustomerBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshCustomerBtn.Location = new System.Drawing.Point(398, 5);
            this.refreshCustomerBtn.Name = "refreshCustomerBtn";
            this.refreshCustomerBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshCustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshCustomerBtn.TabIndex = 5;
            this.refreshCustomerBtn.TabStop = false;
            this.refreshCustomerBtn.Click += new System.EventHandler(this.refreshCustomerBtn_Click);
            // 
            // customerSearchPanel
            // 
            this.customerSearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customerSearchPanel.Controls.Add(this.searchCustomerBtn);
            this.customerSearchPanel.Controls.Add(this.indentityNumberTxt);
            this.customerSearchPanel.Controls.Add(this.codeTxt);
            this.customerSearchPanel.Controls.Add(this.identityNumberLbl);
            this.customerSearchPanel.Controls.Add(this.codeLbl);
            this.customerSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.customerSearchPanel.Name = "customerSearchPanel";
            this.customerSearchPanel.Size = new System.Drawing.Size(796, 62);
            this.customerSearchPanel.TabIndex = 2;
            // 
            // searchCustomerBtn
            // 
            this.searchCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchCustomerBtn.Location = new System.Drawing.Point(595, 21);
            this.searchCustomerBtn.Name = "searchCustomerBtn";
            this.searchCustomerBtn.Size = new System.Drawing.Size(63, 23);
            this.searchCustomerBtn.TabIndex = 4;
            this.searchCustomerBtn.Text = "Tìm";
            this.searchCustomerBtn.UseVisualStyleBackColor = true;
            this.searchCustomerBtn.Click += new System.EventHandler(this.searchCustomerBtn_Click);
            // 
            // indentityNumberTxt
            // 
            this.indentityNumberTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.indentityNumberTxt.Location = new System.Drawing.Point(398, 21);
            this.indentityNumberTxt.Name = "indentityNumberTxt";
            this.indentityNumberTxt.Size = new System.Drawing.Size(148, 20);
            this.indentityNumberTxt.TabIndex = 3;
            // 
            // codeTxt
            // 
            this.codeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTxt.Location = new System.Drawing.Point(146, 21);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(148, 20);
            this.codeTxt.TabIndex = 2;
            // 
            // identityNumberLbl
            // 
            this.identityNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.identityNumberLbl.AutoSize = true;
            this.identityNumberLbl.Location = new System.Drawing.Point(344, 24);
            this.identityNumberLbl.Name = "identityNumberLbl";
            this.identityNumberLbl.Size = new System.Drawing.Size(39, 13);
            this.identityNumberLbl.TabIndex = 1;
            this.identityNumberLbl.Text = "CMND";
            // 
            // codeLbl
            // 
            this.codeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(88, 24);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(40, 13);
            this.codeLbl.TabIndex = 0;
            this.codeLbl.Text = "Mã KH";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteEmployeeBtn);
            this.panel1.Controls.Add(this.addEmployeeBtn);
            this.panel1.Controls.Add(this.refreshEmployeeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 29);
            this.panel1.TabIndex = 0;
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteEmployeeBtn.Image = global::Winform.Properties.Resources.Trash_Recyclebin_Empty_Closed;
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(443, 2);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(28, 26);
            this.deleteEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteEmployeeBtn.TabIndex = 16;
            this.deleteEmployeeBtn.TabStop = false;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addEmployeeBtn.Location = new System.Drawing.Point(387, 2);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(28, 26);
            this.addEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployeeBtn.TabIndex = 14;
            this.addEmployeeBtn.TabStop = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // refreshEmployeeBtn
            // 
            this.refreshEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshEmployeeBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshEmployeeBtn.Location = new System.Drawing.Point(325, 2);
            this.refreshEmployeeBtn.Name = "refreshEmployeeBtn";
            this.refreshEmployeeBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshEmployeeBtn.TabIndex = 15;
            this.refreshEmployeeBtn.TabStop = false;
            this.refreshEmployeeBtn.Click += new System.EventHandler(this.refreshEmployeeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.findroleBtn);
            this.panel2.Controls.Add(this.roleLbl);
            this.panel2.Controls.Add(this.roleTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 52);
            this.panel2.TabIndex = 1;
            // 
            // findroleBtn
            // 
            this.findroleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findroleBtn.Location = new System.Drawing.Point(463, 13);
            this.findroleBtn.Name = "findroleBtn";
            this.findroleBtn.Size = new System.Drawing.Size(63, 23);
            this.findroleBtn.TabIndex = 18;
            this.findroleBtn.Text = "Tìm";
            this.findroleBtn.UseVisualStyleBackColor = true;
            this.findroleBtn.Click += new System.EventHandler(this.findroleBtn_Click);
            // 
            // roleLbl
            // 
            this.roleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(290, 20);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(40, 13);
            this.roleLbl.TabIndex = 0;
            this.roleLbl.Text = "Vai trò:";
            // 
            // roleTxt
            // 
            this.roleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleTxt.Location = new System.Drawing.Point(336, 15);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(121, 20);
            this.roleTxt.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.employeeTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 302);
            this.panel3.TabIndex = 2;
            // 
            // employeeTable
            // 
            this.employeeTable.AllowUserToAddRows = false;
            this.employeeTable.AllowUserToDeleteRows = false;
            this.employeeTable.AllowUserToResizeColumns = false;
            this.employeeTable.AllowUserToResizeRows = false;
            this.employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVaiTro,
            this.Ho,
            this.Ten,
            this.SoCMND,
            this.SDT,
            this.DiaChi,
            this.NgaySinh,
            this.GioiTinh,
            this.RoleName});
            this.employeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTable.Location = new System.Drawing.Point(0, 0);
            this.employeeTable.MultiSelect = false;
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.ReadOnly = true;
            this.employeeTable.RowHeadersVisible = false;
            this.employeeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTable.Size = new System.Drawing.Size(796, 302);
            this.employeeTable.TabIndex = 8;
            // 
            // MaVaiTro
            // 
            this.MaVaiTro.HeaderText = "ID";
            this.MaVaiTro.Name = "MaVaiTro";
            this.MaVaiTro.ReadOnly = true;
            // 
            // Ho
            // 
            this.Ho.HeaderText = "Ho";
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // SoCMND
            // 
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.ReadOnly = true;
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
            // RoleName
            // 
            this.RoleName.HeaderText = "Vai Trò";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.feeTableContainerPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(808, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chi phí";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // feeTableContainerPanel
            // 
            this.feeTableContainerPanel.ColumnCount = 1;
            this.feeTableContainerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.feeTableContainerPanel.Controls.Add(this.feeTable, 0, 1);
            this.feeTableContainerPanel.Controls.Add(this.feeActionPanel, 0, 0);
            this.feeTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feeTableContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.feeTableContainerPanel.Name = "feeTableContainerPanel";
            this.feeTableContainerPanel.RowCount = 2;
            this.feeTableContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94225F));
            this.feeTableContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.05775F));
            this.feeTableContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.feeTableContainerPanel.Size = new System.Drawing.Size(808, 407);
            this.feeTableContainerPanel.TabIndex = 23;
            // 
            // feeTable
            // 
            this.feeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feeTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.feeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FeeType,
            this.Description,
            this.Price,
            this.SubTotal});
            this.feeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feeTable.Location = new System.Drawing.Point(3, 47);
            this.feeTable.Name = "feeTable";
            this.feeTable.Size = new System.Drawing.Size(802, 357);
            this.feeTable.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FeeType
            // 
            this.FeeType.HeaderText = "Loại chi phí";
            this.FeeType.Name = "FeeType";
            // 
            // Description
            // 
            this.Description.HeaderText = "Mô tả";
            this.Description.Name = "Description";
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn giá";
            this.Price.Name = "Price";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Thành tiền";
            this.SubTotal.Name = "SubTotal";
            // 
            // feeActionPanel
            // 
            this.feeActionPanel.Controls.Add(this.refreshFeeBtn);
            this.feeActionPanel.Controls.Add(this.addFeeBtn);
            this.feeActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feeActionPanel.Location = new System.Drawing.Point(3, 3);
            this.feeActionPanel.Name = "feeActionPanel";
            this.feeActionPanel.Size = new System.Drawing.Size(802, 38);
            this.feeActionPanel.TabIndex = 21;
            // 
            // refreshFeeBtn
            // 
            this.refreshFeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshFeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFeeBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshFeeBtn.Location = new System.Drawing.Point(363, 6);
            this.refreshFeeBtn.Name = "refreshFeeBtn";
            this.refreshFeeBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshFeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshFeeBtn.TabIndex = 5;
            this.refreshFeeBtn.TabStop = false;
            this.refreshFeeBtn.Click += new System.EventHandler(this.refreshFeeBtn_Click);
            // 
            // addFeeBtn
            // 
            this.addFeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addFeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFeeBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addFeeBtn.Location = new System.Drawing.Point(411, 6);
            this.addFeeBtn.Name = "addFeeBtn";
            this.addFeeBtn.Size = new System.Drawing.Size(28, 26);
            this.addFeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addFeeBtn.TabIndex = 4;
            this.addFeeBtn.TabStop = false;
            // 
            // GroupDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(816, 433);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "GroupDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết đoàn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.customerContainerPanel.ResumeLayout(false);
            this.customerTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.customerActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshCustomerBtn)).EndInit();
            this.customerSearchPanel.ResumeLayout(false);
            this.customerSearchPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteEmployeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshEmployeeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.feeTableContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feeTable)).EndInit();
            this.feeActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshFeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFeeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel feeTableContainerPanel;
        private System.Windows.Forms.DataGridView feeTable;
        private System.Windows.Forms.Panel feeActionPanel;
        private System.Windows.Forms.PictureBox refreshFeeBtn;
        private System.Windows.Forms.PictureBox addFeeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TableLayoutPanel customerContainerPanel;
        private System.Windows.Forms.Panel customerTablePanel;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.Panel customerActionPanel;
        private System.Windows.Forms.PictureBox refreshCustomerBtn;
        private System.Windows.Forms.Panel customerSearchPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.Button searchCustomerBtn;
        private System.Windows.Forms.TextBox indentityNumberTxt;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label identityNumberLbl;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox deleteEmployeeBtn;
        private System.Windows.Forms.PictureBox addEmployeeBtn;
        private System.Windows.Forms.PictureBox refreshEmployeeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button findroleBtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}