namespace Winform
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tourContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tourSearchPanel = new System.Windows.Forms.Panel();
            this.statusLbl = new System.Windows.Forms.Label();
            this.priceToTxt = new System.Windows.Forms.TextBox();
            this.priceFromTxt = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.resetTourBtn = new System.Windows.Forms.Button();
            this.searchTourBtn = new System.Windows.Forms.Button();
            this.nightTxt = new System.Windows.Forms.TextBox();
            this.dayTxt = new System.Windows.Forms.TextBox();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.districtCb = new System.Windows.Forms.ComboBox();
            this.cityCb = new System.Windows.Forms.ComboBox();
            this.tourTypeCb = new System.Windows.Forms.ComboBox();
            this.tourTypeLbl = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.tourNameTxt = new System.Windows.Forms.TextBox();
            this.tourCodeTxt = new System.Windows.Forms.TextBox();
            this.tourNameLbl = new System.Windows.Forms.Label();
            this.tourCodeLbl = new System.Windows.Forms.Label();
            this.tourTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tourTable = new System.Windows.Forms.DataGridView();
            this.TourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tourActionPanel = new System.Windows.Forms.Panel();
            this.editTourBtn = new System.Windows.Forms.PictureBox();
            this.refreshTourBtn = new System.Windows.Forms.PictureBox();
            this.addTourBtn = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupContainer = new System.Windows.Forms.TableLayoutPanel();
            this.groupSearchPanel = new System.Windows.Forms.Panel();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.resetGroupBtn = new System.Windows.Forms.Button();
            this.searchGroupBtn = new System.Windows.Forms.Button();
            this.groupNameTxt = new System.Windows.Forms.TextBox();
            this.groupCodeTxt = new System.Windows.Forms.TextBox();
            this.groupNameLbl = new System.Windows.Forms.Label();
            this.groupCodeLbl = new System.Windows.Forms.Label();
            this.groupTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupTable = new System.Windows.Forms.DataGridView();
            this.groupActionPanel = new System.Windows.Forms.Panel();
            this.editGroupBtn = new System.Windows.Forms.PictureBox();
            this.refreshGroupBtn = new System.Windows.Forms.PictureBox();
            this.addGroupBtn = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportContainer = new System.Windows.Forms.TableLayoutPanel();
            this.reportSearchPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.reportToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportTablePanel = new System.Windows.Forms.Panel();
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.TourOrGroupCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourOrGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeContainer = new System.Windows.Forms.TableLayoutPanel();
            this.employeeSearchPanel = new System.Windows.Forms.Panel();
            this.resetEmployeeBtn = new System.Windows.Forms.Button();
            this.searchEmployeeBtn = new System.Windows.Forms.Button();
            this.employeeCodeLbl = new System.Windows.Forms.Label();
            this.employeeCodeTxt = new System.Windows.Forms.TextBox();
            this.employeeIdentityNumberTxt = new System.Windows.Forms.TextBox();
            this.employeeIdentityNumberLbl = new System.Windows.Forms.Label();
            this.employeeFirstNameTxt = new System.Windows.Forms.TextBox();
            this.employeeFirstNameLbl = new System.Windows.Forms.Label();
            this.employeeLastNameTxt = new System.Windows.Forms.TextBox();
            this.employeeLastNameLbl = new System.Windows.Forms.Label();
            this.employeeTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeActionPanel = new System.Windows.Forms.Panel();
            this.editEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.refreshEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.addEmployeeBtn = new System.Windows.Forms.PictureBox();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourCodeOfGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tourContainer.SuspendLayout();
            this.tourSearchPanel.SuspendLayout();
            this.tourTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.tourActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTourBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshTourBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTourBtn)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupContainer.SuspendLayout();
            this.groupSearchPanel.SuspendLayout();
            this.groupTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTable)).BeginInit();
            this.groupActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editGroupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshGroupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGroupBtn)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.reportContainer.SuspendLayout();
            this.reportSearchPanel.SuspendLayout();
            this.reportTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.employeeContainer.SuspendLayout();
            this.employeeSearchPanel.SuspendLayout();
            this.employeeTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.employeeActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshEmployeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 561);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tourContainer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tourContainer
            // 
            this.tourContainer.ColumnCount = 1;
            this.tourContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tourContainer.Controls.Add(this.tourSearchPanel, 0, 0);
            this.tourContainer.Controls.Add(this.tourTablePanel, 0, 2);
            this.tourContainer.Controls.Add(this.panel1, 0, 1);
            this.tourContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourContainer.Location = new System.Drawing.Point(3, 3);
            this.tourContainer.Name = "tourContainer";
            this.tourContainer.RowCount = 3;
            this.tourContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.87F));
            this.tourContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.18F));
            this.tourContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.95F));
            this.tourContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tourContainer.Size = new System.Drawing.Size(870, 522);
            this.tourContainer.TabIndex = 21;
            // 
            // tourSearchPanel
            // 
            this.tourSearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tourSearchPanel.Controls.Add(this.statusLbl);
            this.tourSearchPanel.Controls.Add(this.priceToTxt);
            this.tourSearchPanel.Controls.Add(this.priceFromTxt);
            this.tourSearchPanel.Controls.Add(this.priceLbl);
            this.tourSearchPanel.Controls.Add(this.resetTourBtn);
            this.tourSearchPanel.Controls.Add(this.searchTourBtn);
            this.tourSearchPanel.Controls.Add(this.nightTxt);
            this.tourSearchPanel.Controls.Add(this.dayTxt);
            this.tourSearchPanel.Controls.Add(this.statusCb);
            this.tourSearchPanel.Controls.Add(this.districtCb);
            this.tourSearchPanel.Controls.Add(this.cityCb);
            this.tourSearchPanel.Controls.Add(this.tourTypeCb);
            this.tourSearchPanel.Controls.Add(this.tourTypeLbl);
            this.tourSearchPanel.Controls.Add(this.durationLbl);
            this.tourSearchPanel.Controls.Add(this.fromLbl);
            this.tourSearchPanel.Controls.Add(this.tourNameTxt);
            this.tourSearchPanel.Controls.Add(this.tourCodeTxt);
            this.tourSearchPanel.Controls.Add(this.tourNameLbl);
            this.tourSearchPanel.Controls.Add(this.tourCodeLbl);
            this.tourSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourSearchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.tourSearchPanel.Name = "tourSearchPanel";
            this.tourSearchPanel.Size = new System.Drawing.Size(864, 149);
            this.tourSearchPanel.TabIndex = 19;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(329, 117);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(67, 16);
            this.statusLbl.TabIndex = 26;
            this.statusLbl.Text = "Tình trạng";
            // 
            // priceToTxt
            // 
            this.priceToTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceToTxt.Location = new System.Drawing.Point(735, 67);
            this.priceToTxt.Name = "priceToTxt";
            this.priceToTxt.Size = new System.Drawing.Size(79, 22);
            this.priceToTxt.TabIndex = 25;
            this.priceToTxt.Text = "giá đến";
            // 
            // priceFromTxt
            // 
            this.priceFromTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceFromTxt.Location = new System.Drawing.Point(654, 67);
            this.priceFromTxt.Name = "priceFromTxt";
            this.priceFromTxt.Size = new System.Drawing.Size(75, 22);
            this.priceFromTxt.TabIndex = 24;
            this.priceFromTxt.Text = "giá từ";
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(614, 70);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(29, 16);
            this.priceLbl.TabIndex = 23;
            this.priceLbl.Text = "Giá";
            // 
            // resetTourBtn
            // 
            this.resetTourBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetTourBtn.Location = new System.Drawing.Point(640, 114);
            this.resetTourBtn.Name = "resetTourBtn";
            this.resetTourBtn.Size = new System.Drawing.Size(67, 27);
            this.resetTourBtn.TabIndex = 22;
            this.resetTourBtn.Text = "Hủy";
            this.resetTourBtn.UseVisualStyleBackColor = true;
            this.resetTourBtn.Click += new System.EventHandler(this.resetTourBtn_Click);
            // 
            // searchTourBtn
            // 
            this.searchTourBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTourBtn.Location = new System.Drawing.Point(747, 114);
            this.searchTourBtn.Name = "searchTourBtn";
            this.searchTourBtn.Size = new System.Drawing.Size(67, 27);
            this.searchTourBtn.TabIndex = 18;
            this.searchTourBtn.Text = "Tìm";
            this.searchTourBtn.UseVisualStyleBackColor = true;
            this.searchTourBtn.Click += new System.EventHandler(this.searchTourBtn_Click);
            // 
            // nightTxt
            // 
            this.nightTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nightTxt.Location = new System.Drawing.Point(501, 67);
            this.nightTxt.Name = "nightTxt";
            this.nightTxt.Size = new System.Drawing.Size(79, 22);
            this.nightTxt.TabIndex = 17;
            this.nightTxt.Text = "đêm";
            // 
            // dayTxt
            // 
            this.dayTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayTxt.Location = new System.Drawing.Point(420, 67);
            this.dayTxt.Name = "dayTxt";
            this.dayTxt.Size = new System.Drawing.Size(75, 22);
            this.dayTxt.TabIndex = 16;
            this.dayTxt.Text = "ngày";
            // 
            // statusCb
            // 
            this.statusCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Location = new System.Drawing.Point(420, 114);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(160, 24);
            this.statusCb.TabIndex = 15;
            // 
            // districtCb
            // 
            this.districtCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.districtCb.FormattingEnabled = true;
            this.districtCb.Location = new System.Drawing.Point(616, 17);
            this.districtCb.Name = "districtCb";
            this.districtCb.Size = new System.Drawing.Size(198, 24);
            this.districtCb.TabIndex = 13;
            // 
            // cityCb
            // 
            this.cityCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityCb.FormattingEnabled = true;
            this.cityCb.Location = new System.Drawing.Point(420, 16);
            this.cityCb.Name = "cityCb";
            this.cityCb.Size = new System.Drawing.Size(160, 24);
            this.cityCb.TabIndex = 12;
            this.cityCb.SelectedIndexChanged += new System.EventHandler(this.cityCb_SelectedIndexChanged);
            // 
            // tourTypeCb
            // 
            this.tourTypeCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourTypeCb.FormattingEnabled = true;
            this.tourTypeCb.Location = new System.Drawing.Point(120, 117);
            this.tourTypeCb.Name = "tourTypeCb";
            this.tourTypeCb.Size = new System.Drawing.Size(161, 24);
            this.tourTypeCb.TabIndex = 11;
            // 
            // tourTypeLbl
            // 
            this.tourTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourTypeLbl.AutoSize = true;
            this.tourTypeLbl.Location = new System.Drawing.Point(44, 120);
            this.tourTypeLbl.Name = "tourTypeLbl";
            this.tourTypeLbl.Size = new System.Drawing.Size(59, 16);
            this.tourTypeLbl.TabIndex = 10;
            this.tourTypeLbl.Text = "Loại tour";
            // 
            // durationLbl
            // 
            this.durationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationLbl.AutoSize = true;
            this.durationLbl.Location = new System.Drawing.Point(329, 69);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(58, 16);
            this.durationLbl.TabIndex = 8;
            this.durationLbl.Text = "Số ngày";
            // 
            // fromLbl
            // 
            this.fromLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(329, 19);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(85, 16);
            this.fromLbl.TabIndex = 6;
            this.fromLbl.Text = "Nơi xuất phát";
            // 
            // tourNameTxt
            // 
            this.tourNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourNameTxt.Location = new System.Drawing.Point(120, 66);
            this.tourNameTxt.Name = "tourNameTxt";
            this.tourNameTxt.Size = new System.Drawing.Size(161, 22);
            this.tourNameTxt.TabIndex = 4;
            // 
            // tourCodeTxt
            // 
            this.tourCodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourCodeTxt.Location = new System.Drawing.Point(120, 17);
            this.tourCodeTxt.Name = "tourCodeTxt";
            this.tourCodeTxt.Size = new System.Drawing.Size(161, 22);
            this.tourCodeTxt.TabIndex = 3;
            // 
            // tourNameLbl
            // 
            this.tourNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourNameLbl.AutoSize = true;
            this.tourNameLbl.Location = new System.Drawing.Point(44, 69);
            this.tourNameLbl.Name = "tourNameLbl";
            this.tourNameLbl.Size = new System.Drawing.Size(57, 16);
            this.tourNameLbl.TabIndex = 2;
            this.tourNameLbl.Text = "Tên tour";
            // 
            // tourCodeLbl
            // 
            this.tourCodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tourCodeLbl.AutoSize = true;
            this.tourCodeLbl.Location = new System.Drawing.Point(44, 20);
            this.tourCodeLbl.Name = "tourCodeLbl";
            this.tourCodeLbl.Size = new System.Drawing.Size(52, 16);
            this.tourCodeLbl.TabIndex = 1;
            this.tourCodeLbl.Text = "Mã tour";
            // 
            // tourTablePanel
            // 
            this.tourTablePanel.ColumnCount = 1;
            this.tourTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tourTablePanel.Controls.Add(this.tourTable, 0, 0);
            this.tourTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourTablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourTablePanel.Location = new System.Drawing.Point(3, 195);
            this.tourTablePanel.Name = "tourTablePanel";
            this.tourTablePanel.RowCount = 1;
            this.tourTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tourTablePanel.Size = new System.Drawing.Size(864, 324);
            this.tourTablePanel.TabIndex = 20;
            // 
            // tourTable
            // 
            this.tourTable.AllowUserToAddRows = false;
            this.tourTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tourTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tourTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tourTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TourID,
            this.TourCode,
            this.TourName,
            this.TourType,
            this.From,
            this.Day,
            this.Night,
            this.TourPrice,
            this.Status,
            this.TourDescription,
            this.ViewGroup});
            this.tourTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourTable.Location = new System.Drawing.Point(3, 3);
            this.tourTable.Name = "tourTable";
            this.tourTable.Size = new System.Drawing.Size(858, 318);
            this.tourTable.TabIndex = 2;
            this.tourTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewTourDetail);
            this.tourTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourTable_CellDoubleClick);
            this.tourTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tourTable_CellMouseMove);
            // 
            // TourID
            // 
            this.TourID.HeaderText = "ID";
            this.TourID.Name = "TourID";
            this.TourID.Visible = false;
            // 
            // TourCode
            // 
            this.TourCode.HeaderText = "Mã tour";
            this.TourCode.Name = "TourCode";
            // 
            // TourName
            // 
            this.TourName.HeaderText = "Tên tour";
            this.TourName.Name = "TourName";
            // 
            // TourType
            // 
            this.TourType.HeaderText = "Loại tour";
            this.TourType.Name = "TourType";
            // 
            // From
            // 
            this.From.HeaderText = "Nơi xuất phát";
            this.From.Name = "From";
            // 
            // Day
            // 
            this.Day.HeaderText = "Số ngày";
            this.Day.Name = "Day";
            // 
            // Night
            // 
            this.Night.HeaderText = "Số đêm";
            this.Night.Name = "Night";
            // 
            // TourPrice
            // 
            this.TourPrice.HeaderText = "Đơn giá";
            this.TourPrice.Name = "TourPrice";
            // 
            // Status
            // 
            this.Status.HeaderText = "Tình trạng";
            this.Status.Name = "Status";
            // 
            // TourDescription
            // 
            this.TourDescription.HeaderText = "Mô tả";
            this.TourDescription.Name = "TourDescription";
            // 
            // ViewGroup
            // 
            this.ViewGroup.HeaderText = "";
            this.ViewGroup.Name = "ViewGroup";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tourActionPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 31);
            this.panel1.TabIndex = 21;
            // 
            // tourActionPanel
            // 
            this.tourActionPanel.Controls.Add(this.editTourBtn);
            this.tourActionPanel.Controls.Add(this.refreshTourBtn);
            this.tourActionPanel.Controls.Add(this.addTourBtn);
            this.tourActionPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tourActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourActionPanel.Location = new System.Drawing.Point(0, 0);
            this.tourActionPanel.Name = "tourActionPanel";
            this.tourActionPanel.Size = new System.Drawing.Size(864, 31);
            this.tourActionPanel.TabIndex = 4;
            // 
            // editTourBtn
            // 
            this.editTourBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editTourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTourBtn.Image = global::Winform.Properties.Resources.edit;
            this.editTourBtn.Location = new System.Drawing.Point(497, 1);
            this.editTourBtn.Name = "editTourBtn";
            this.editTourBtn.Size = new System.Drawing.Size(28, 26);
            this.editTourBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editTourBtn.TabIndex = 10;
            this.editTourBtn.TabStop = false;
            this.editTourBtn.Click += new System.EventHandler(this.editTourBtn_Click);
            // 
            // refreshTourBtn
            // 
            this.refreshTourBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshTourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshTourBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshTourBtn.Location = new System.Drawing.Point(392, 1);
            this.refreshTourBtn.Name = "refreshTourBtn";
            this.refreshTourBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshTourBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshTourBtn.TabIndex = 3;
            this.refreshTourBtn.TabStop = false;
            this.refreshTourBtn.Click += new System.EventHandler(this.refreshTourBtn_Click);
            // 
            // addTourBtn
            // 
            this.addTourBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTourBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addTourBtn.Location = new System.Drawing.Point(440, 1);
            this.addTourBtn.Name = "addTourBtn";
            this.addTourBtn.Size = new System.Drawing.Size(28, 26);
            this.addTourBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addTourBtn.TabIndex = 2;
            this.addTourBtn.TabStop = false;
            this.addTourBtn.Click += new System.EventHandler(this.createTourBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupContainer);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đoàn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupContainer
            // 
            this.groupContainer.ColumnCount = 1;
            this.groupContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupContainer.Controls.Add(this.groupSearchPanel, 0, 0);
            this.groupContainer.Controls.Add(this.groupTablePanel, 0, 2);
            this.groupContainer.Controls.Add(this.groupActionPanel, 0, 1);
            this.groupContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupContainer.Location = new System.Drawing.Point(3, 3);
            this.groupContainer.Name = "groupContainer";
            this.groupContainer.RowCount = 3;
            this.groupContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.86768F));
            this.groupContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.183365F));
            this.groupContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.94896F));
            this.groupContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.groupContainer.Size = new System.Drawing.Size(870, 522);
            this.groupContainer.TabIndex = 21;
            // 
            // groupSearchPanel
            // 
            this.groupSearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupSearchPanel.Controls.Add(this.endDatePicker);
            this.groupSearchPanel.Controls.Add(this.endDateLbl);
            this.groupSearchPanel.Controls.Add(this.startDatePicker);
            this.groupSearchPanel.Controls.Add(this.startDateLbl);
            this.groupSearchPanel.Controls.Add(this.resetGroupBtn);
            this.groupSearchPanel.Controls.Add(this.searchGroupBtn);
            this.groupSearchPanel.Controls.Add(this.groupNameTxt);
            this.groupSearchPanel.Controls.Add(this.groupCodeTxt);
            this.groupSearchPanel.Controls.Add(this.groupNameLbl);
            this.groupSearchPanel.Controls.Add(this.groupCodeLbl);
            this.groupSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSearchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.groupSearchPanel.Name = "groupSearchPanel";
            this.groupSearchPanel.Size = new System.Drawing.Size(864, 149);
            this.groupSearchPanel.TabIndex = 19;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDatePicker.Location = new System.Drawing.Point(515, 68);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(165, 22);
            this.endDatePicker.TabIndex = 34;
            // 
            // endDateLbl
            // 
            this.endDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(441, 68);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(59, 16);
            this.endDateLbl.TabIndex = 33;
            this.endDateLbl.Text = "Ngày về";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDatePicker.Location = new System.Drawing.Point(227, 68);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(165, 22);
            this.startDatePicker.TabIndex = 32;
            this.startDatePicker.Value = new System.DateTime(2017, 11, 27, 0, 0, 0, 0);
            // 
            // startDateLbl
            // 
            this.startDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(141, 68);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(55, 16);
            this.startDateLbl.TabIndex = 31;
            this.startDateLbl.Text = "Ngày đi";
            // 
            // resetGroupBtn
            // 
            this.resetGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetGroupBtn.Location = new System.Drawing.Point(527, 116);
            this.resetGroupBtn.Name = "resetGroupBtn";
            this.resetGroupBtn.Size = new System.Drawing.Size(67, 27);
            this.resetGroupBtn.TabIndex = 22;
            this.resetGroupBtn.Text = "Hủy";
            this.resetGroupBtn.UseVisualStyleBackColor = true;
            // 
            // searchGroupBtn
            // 
            this.searchGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchGroupBtn.Location = new System.Drawing.Point(613, 116);
            this.searchGroupBtn.Name = "searchGroupBtn";
            this.searchGroupBtn.Size = new System.Drawing.Size(67, 27);
            this.searchGroupBtn.TabIndex = 18;
            this.searchGroupBtn.Text = "Tìm";
            this.searchGroupBtn.UseVisualStyleBackColor = true;
            // 
            // groupNameTxt
            // 
            this.groupNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameTxt.Location = new System.Drawing.Point(515, 15);
            this.groupNameTxt.Name = "groupNameTxt";
            this.groupNameTxt.Size = new System.Drawing.Size(165, 22);
            this.groupNameTxt.TabIndex = 4;
            // 
            // groupCodeTxt
            // 
            this.groupCodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupCodeTxt.Location = new System.Drawing.Point(227, 15);
            this.groupCodeTxt.Name = "groupCodeTxt";
            this.groupCodeTxt.Size = new System.Drawing.Size(165, 22);
            this.groupCodeTxt.TabIndex = 3;
            // 
            // groupNameLbl
            // 
            this.groupNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameLbl.AutoSize = true;
            this.groupNameLbl.Location = new System.Drawing.Point(441, 18);
            this.groupNameLbl.Name = "groupNameLbl";
            this.groupNameLbl.Size = new System.Drawing.Size(66, 16);
            this.groupNameLbl.TabIndex = 2;
            this.groupNameLbl.Text = "Tên đoàn";
            // 
            // groupCodeLbl
            // 
            this.groupCodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupCodeLbl.AutoSize = true;
            this.groupCodeLbl.Location = new System.Drawing.Point(141, 18);
            this.groupCodeLbl.Name = "groupCodeLbl";
            this.groupCodeLbl.Size = new System.Drawing.Size(61, 16);
            this.groupCodeLbl.TabIndex = 1;
            this.groupCodeLbl.Text = "Mã đoàn";
            // 
            // groupTablePanel
            // 
            this.groupTablePanel.ColumnCount = 1;
            this.groupTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupTablePanel.Controls.Add(this.groupTable, 0, 0);
            this.groupTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTablePanel.Location = new System.Drawing.Point(3, 195);
            this.groupTablePanel.Name = "groupTablePanel";
            this.groupTablePanel.RowCount = 1;
            this.groupTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.groupTablePanel.Size = new System.Drawing.Size(864, 324);
            this.groupTablePanel.TabIndex = 20;
            // 
            // groupTable
            // 
            this.groupTable.AllowUserToAddRows = false;
            this.groupTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupCode,
            this.TourCodeOfGroup,
            this.GroupName,
            this.StartDate,
            this.EndDate,
            this.PickupLocation,
            this.DropLocation,
            this.GroupDescription,
            this.Policy,
            this.dataGridViewTextBoxColumn4});
            this.groupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTable.Location = new System.Drawing.Point(3, 3);
            this.groupTable.Name = "groupTable";
            this.groupTable.Size = new System.Drawing.Size(858, 318);
            this.groupTable.TabIndex = 3;
            this.groupTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupTable_CellDoubleClick);
            this.groupTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.groupTable_CellMouseMove);
            // 
            // groupActionPanel
            // 
            this.groupActionPanel.Controls.Add(this.editGroupBtn);
            this.groupActionPanel.Controls.Add(this.refreshGroupBtn);
            this.groupActionPanel.Controls.Add(this.addGroupBtn);
            this.groupActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupActionPanel.Location = new System.Drawing.Point(3, 158);
            this.groupActionPanel.Name = "groupActionPanel";
            this.groupActionPanel.Size = new System.Drawing.Size(864, 31);
            this.groupActionPanel.TabIndex = 21;
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editGroupBtn.Image = global::Winform.Properties.Resources.edit;
            this.editGroupBtn.Location = new System.Drawing.Point(497, 1);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(28, 26);
            this.editGroupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editGroupBtn.TabIndex = 11;
            this.editGroupBtn.TabStop = false;
            this.editGroupBtn.Click += new System.EventHandler(this.editGroupBtn_Click);
            // 
            // refreshGroupBtn
            // 
            this.refreshGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshGroupBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshGroupBtn.Location = new System.Drawing.Point(392, 1);
            this.refreshGroupBtn.Name = "refreshGroupBtn";
            this.refreshGroupBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshGroupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshGroupBtn.TabIndex = 5;
            this.refreshGroupBtn.TabStop = false;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGroupBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addGroupBtn.Location = new System.Drawing.Point(440, 1);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(28, 26);
            this.addGroupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addGroupBtn.TabIndex = 4;
            this.addGroupBtn.TabStop = false;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportContainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportContainer
            // 
            this.reportContainer.ColumnCount = 1;
            this.reportContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportContainer.Controls.Add(this.reportSearchPanel, 0, 0);
            this.reportContainer.Controls.Add(this.reportTablePanel, 0, 1);
            this.reportContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportContainer.Location = new System.Drawing.Point(0, 0);
            this.reportContainer.Name = "reportContainer";
            this.reportContainer.RowCount = 2;
            this.reportContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reportContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.reportContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.reportContainer.Size = new System.Drawing.Size(876, 528);
            this.reportContainer.TabIndex = 0;
            // 
            // reportSearchPanel
            // 
            this.reportSearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportSearchPanel.Controls.Add(this.label2);
            this.reportSearchPanel.Controls.Add(this.label1);
            this.reportSearchPanel.Controls.Add(this.reportBtn);
            this.reportSearchPanel.Controls.Add(this.reportToDatePicker);
            this.reportSearchPanel.Controls.Add(this.reportFromDatePicker);
            this.reportSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportSearchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.reportSearchPanel.Name = "reportSearchPanel";
            this.reportSearchPanel.Size = new System.Drawing.Size(870, 77);
            this.reportSearchPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // reportBtn
            // 
            this.reportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportBtn.Location = new System.Drawing.Point(687, 24);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(75, 28);
            this.reportBtn.TabIndex = 2;
            this.reportBtn.Text = "Thống kê";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // reportToDatePicker
            // 
            this.reportToDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportToDatePicker.Location = new System.Drawing.Point(454, 27);
            this.reportToDatePicker.Name = "reportToDatePicker";
            this.reportToDatePicker.Size = new System.Drawing.Size(200, 22);
            this.reportToDatePicker.TabIndex = 1;
            // 
            // reportFromDatePicker
            // 
            this.reportFromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportFromDatePicker.Location = new System.Drawing.Point(148, 27);
            this.reportFromDatePicker.Name = "reportFromDatePicker";
            this.reportFromDatePicker.Size = new System.Drawing.Size(200, 22);
            this.reportFromDatePicker.TabIndex = 0;
            // 
            // reportTablePanel
            // 
            this.reportTablePanel.Controls.Add(this.reportTable);
            this.reportTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTablePanel.Location = new System.Drawing.Point(3, 86);
            this.reportTablePanel.Name = "reportTablePanel";
            this.reportTablePanel.Size = new System.Drawing.Size(870, 439);
            this.reportTablePanel.TabIndex = 2;
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TourOrGroupCode,
            this.TourOrGroupName,
            this.ReportStartDate,
            this.ReportEndDate,
            this.ReportPrice,
            this.ReportTotal,
            this.Revenue});
            this.reportTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTable.Location = new System.Drawing.Point(0, 0);
            this.reportTable.Name = "reportTable";
            this.reportTable.Size = new System.Drawing.Size(870, 439);
            this.reportTable.TabIndex = 0;
            // 
            // TourOrGroupCode
            // 
            this.TourOrGroupCode.HeaderText = "Mã";
            this.TourOrGroupCode.Name = "TourOrGroupCode";
            // 
            // TourOrGroupName
            // 
            this.TourOrGroupName.HeaderText = "Tên";
            this.TourOrGroupName.Name = "TourOrGroupName";
            // 
            // ReportStartDate
            // 
            this.ReportStartDate.HeaderText = "Ngày đi";
            this.ReportStartDate.Name = "ReportStartDate";
            // 
            // ReportEndDate
            // 
            this.ReportEndDate.HeaderText = "Ngày về";
            this.ReportEndDate.Name = "ReportEndDate";
            // 
            // ReportPrice
            // 
            this.ReportPrice.HeaderText = "Đơn giá/Chi phí";
            this.ReportPrice.Name = "ReportPrice";
            // 
            // ReportTotal
            // 
            this.ReportTotal.HeaderText = "Tổng thu/Tổng chi";
            this.ReportTotal.Name = "ReportTotal";
            // 
            // Revenue
            // 
            this.Revenue.HeaderText = "Tiền lời";
            this.Revenue.Name = "Revenue";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.employeeContainer);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(876, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhân viên";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // employeeContainer
            // 
            this.employeeContainer.ColumnCount = 1;
            this.employeeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.employeeContainer.Controls.Add(this.employeeSearchPanel, 0, 0);
            this.employeeContainer.Controls.Add(this.employeeTablePanel, 0, 2);
            this.employeeContainer.Controls.Add(this.employeeActionPanel, 0, 1);
            this.employeeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeContainer.Location = new System.Drawing.Point(0, 0);
            this.employeeContainer.Name = "employeeContainer";
            this.employeeContainer.RowCount = 3;
            this.employeeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.87F));
            this.employeeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.18F));
            this.employeeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.95F));
            this.employeeContainer.Size = new System.Drawing.Size(876, 528);
            this.employeeContainer.TabIndex = 22;
            // 
            // employeeSearchPanel
            // 
            this.employeeSearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeSearchPanel.Controls.Add(this.resetEmployeeBtn);
            this.employeeSearchPanel.Controls.Add(this.searchEmployeeBtn);
            this.employeeSearchPanel.Controls.Add(this.employeeCodeLbl);
            this.employeeSearchPanel.Controls.Add(this.employeeCodeTxt);
            this.employeeSearchPanel.Controls.Add(this.employeeIdentityNumberTxt);
            this.employeeSearchPanel.Controls.Add(this.employeeIdentityNumberLbl);
            this.employeeSearchPanel.Controls.Add(this.employeeFirstNameTxt);
            this.employeeSearchPanel.Controls.Add(this.employeeFirstNameLbl);
            this.employeeSearchPanel.Controls.Add(this.employeeLastNameTxt);
            this.employeeSearchPanel.Controls.Add(this.employeeLastNameLbl);
            this.employeeSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSearchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.employeeSearchPanel.Name = "employeeSearchPanel";
            this.employeeSearchPanel.Size = new System.Drawing.Size(870, 151);
            this.employeeSearchPanel.TabIndex = 19;
            // 
            // resetEmployeeBtn
            // 
            this.resetEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetEmployeeBtn.Location = new System.Drawing.Point(599, 111);
            this.resetEmployeeBtn.Name = "resetEmployeeBtn";
            this.resetEmployeeBtn.Size = new System.Drawing.Size(67, 27);
            this.resetEmployeeBtn.TabIndex = 42;
            this.resetEmployeeBtn.Text = "Hủy";
            this.resetEmployeeBtn.UseVisualStyleBackColor = true;
            this.resetEmployeeBtn.Click += new System.EventHandler(this.resetEmployeeBtn_Click);
            // 
            // searchEmployeeBtn
            // 
            this.searchEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchEmployeeBtn.Location = new System.Drawing.Point(685, 111);
            this.searchEmployeeBtn.Name = "searchEmployeeBtn";
            this.searchEmployeeBtn.Size = new System.Drawing.Size(67, 27);
            this.searchEmployeeBtn.TabIndex = 41;
            this.searchEmployeeBtn.Text = "Tìm";
            this.searchEmployeeBtn.UseVisualStyleBackColor = true;
            this.searchEmployeeBtn.Click += new System.EventHandler(this.searchEmployeeBtn_Click);
            // 
            // employeeCodeLbl
            // 
            this.employeeCodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeCodeLbl.AutoSize = true;
            this.employeeCodeLbl.Location = new System.Drawing.Point(128, 22);
            this.employeeCodeLbl.Name = "employeeCodeLbl";
            this.employeeCodeLbl.Size = new System.Drawing.Size(87, 16);
            this.employeeCodeLbl.TabIndex = 40;
            this.employeeCodeLbl.Text = "Mã nhân viên";
            // 
            // employeeCodeTxt
            // 
            this.employeeCodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeCodeTxt.Location = new System.Drawing.Point(246, 19);
            this.employeeCodeTxt.Name = "employeeCodeTxt";
            this.employeeCodeTxt.Size = new System.Drawing.Size(159, 22);
            this.employeeCodeTxt.TabIndex = 39;
            // 
            // employeeIdentityNumberTxt
            // 
            this.employeeIdentityNumberTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeIdentityNumberTxt.Location = new System.Drawing.Point(599, 19);
            this.employeeIdentityNumberTxt.Name = "employeeIdentityNumberTxt";
            this.employeeIdentityNumberTxt.Size = new System.Drawing.Size(151, 22);
            this.employeeIdentityNumberTxt.TabIndex = 29;
            // 
            // employeeIdentityNumberLbl
            // 
            this.employeeIdentityNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeIdentityNumberLbl.AutoSize = true;
            this.employeeIdentityNumberLbl.Location = new System.Drawing.Point(486, 20);
            this.employeeIdentityNumberLbl.Name = "employeeIdentityNumberLbl";
            this.employeeIdentityNumberLbl.Size = new System.Drawing.Size(68, 16);
            this.employeeIdentityNumberLbl.TabIndex = 28;
            this.employeeIdentityNumberLbl.Text = "Số CMND";
            // 
            // employeeFirstNameTxt
            // 
            this.employeeFirstNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeFirstNameTxt.Location = new System.Drawing.Point(599, 70);
            this.employeeFirstNameTxt.Name = "employeeFirstNameTxt";
            this.employeeFirstNameTxt.Size = new System.Drawing.Size(151, 22);
            this.employeeFirstNameTxt.TabIndex = 27;
            // 
            // employeeFirstNameLbl
            // 
            this.employeeFirstNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeFirstNameLbl.AutoSize = true;
            this.employeeFirstNameLbl.Location = new System.Drawing.Point(486, 71);
            this.employeeFirstNameLbl.Name = "employeeFirstNameLbl";
            this.employeeFirstNameLbl.Size = new System.Drawing.Size(32, 16);
            this.employeeFirstNameLbl.TabIndex = 26;
            this.employeeFirstNameLbl.Text = "Tên";
            // 
            // employeeLastNameTxt
            // 
            this.employeeLastNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLastNameTxt.Location = new System.Drawing.Point(246, 68);
            this.employeeLastNameTxt.Name = "employeeLastNameTxt";
            this.employeeLastNameTxt.Size = new System.Drawing.Size(159, 22);
            this.employeeLastNameTxt.TabIndex = 25;
            // 
            // employeeLastNameLbl
            // 
            this.employeeLastNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLastNameLbl.AutoSize = true;
            this.employeeLastNameLbl.Location = new System.Drawing.Point(129, 71);
            this.employeeLastNameLbl.Name = "employeeLastNameLbl";
            this.employeeLastNameLbl.Size = new System.Drawing.Size(26, 16);
            this.employeeLastNameLbl.TabIndex = 24;
            this.employeeLastNameLbl.Text = "Họ";
            // 
            // employeeTablePanel
            // 
            this.employeeTablePanel.ColumnCount = 1;
            this.employeeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.employeeTablePanel.Controls.Add(this.employeeTable, 0, 0);
            this.employeeTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTablePanel.Location = new System.Drawing.Point(3, 197);
            this.employeeTablePanel.Name = "employeeTablePanel";
            this.employeeTablePanel.RowCount = 1;
            this.employeeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.employeeTablePanel.Size = new System.Drawing.Size(870, 328);
            this.employeeTablePanel.TabIndex = 20;
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
            this.employeeTable.Location = new System.Drawing.Point(3, 3);
            this.employeeTable.MultiSelect = false;
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.ReadOnly = true;
            this.employeeTable.RowHeadersVisible = false;
            this.employeeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTable.Size = new System.Drawing.Size(864, 322);
            this.employeeTable.TabIndex = 3;
            this.employeeTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeTable_CellDoubleClick);
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
            this.SDT.HeaderText = "SĐT";
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
            // employeeActionPanel
            // 
            this.employeeActionPanel.Controls.Add(this.editEmployeeBtn);
            this.employeeActionPanel.Controls.Add(this.refreshEmployeeBtn);
            this.employeeActionPanel.Controls.Add(this.addEmployeeBtn);
            this.employeeActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeActionPanel.Location = new System.Drawing.Point(3, 160);
            this.employeeActionPanel.Name = "employeeActionPanel";
            this.employeeActionPanel.Size = new System.Drawing.Size(870, 31);
            this.employeeActionPanel.TabIndex = 21;
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editEmployeeBtn.Image = global::Winform.Properties.Resources.edit;
            this.editEmployeeBtn.Location = new System.Drawing.Point(500, 1);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(28, 26);
            this.editEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editEmployeeBtn.TabIndex = 13;
            this.editEmployeeBtn.TabStop = false;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // refreshEmployeeBtn
            // 
            this.refreshEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshEmployeeBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshEmployeeBtn.Location = new System.Drawing.Point(395, 1);
            this.refreshEmployeeBtn.Name = "refreshEmployeeBtn";
            this.refreshEmployeeBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshEmployeeBtn.TabIndex = 12;
            this.refreshEmployeeBtn.TabStop = false;
            this.refreshEmployeeBtn.Click += new System.EventHandler(this.refreshEmployeeBtn_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addEmployeeBtn.Location = new System.Drawing.Point(443, 1);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(28, 26);
            this.addEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployeeBtn.TabIndex = 11;
            this.addEmployeeBtn.TabStop = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // GroupID
            // 
            this.GroupID.HeaderText = "ID";
            this.GroupID.Name = "GroupID";
            this.GroupID.Visible = false;
            // 
            // GroupCode
            // 
            this.GroupCode.HeaderText = "Mã đoàn";
            this.GroupCode.Name = "GroupCode";
            // 
            // TourCodeOfGroup
            // 
            this.TourCodeOfGroup.HeaderText = "Mã tour";
            this.TourCodeOfGroup.Name = "TourCodeOfGroup";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Tên đoàn";
            this.GroupName.Name = "GroupName";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Ngày đi";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Ngày về";
            this.EndDate.Name = "EndDate";
            // 
            // PickupLocation
            // 
            this.PickupLocation.HeaderText = "Địa điểm rước";
            this.PickupLocation.Name = "PickupLocation";
            // 
            // DropLocation
            // 
            this.DropLocation.HeaderText = "Địa điểm thả";
            this.DropLocation.Name = "DropLocation";
            // 
            // GroupDescription
            // 
            this.GroupDescription.HeaderText = "Hành trình";
            this.GroupDescription.Name = "GroupDescription";
            // 
            // Policy
            // 
            this.Policy.HeaderText = "Chính sách";
            this.Policy.Name = "Policy";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ TOUR DU LỊCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tourContainer.ResumeLayout(false);
            this.tourSearchPanel.ResumeLayout(false);
            this.tourSearchPanel.PerformLayout();
            this.tourTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tourActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editTourBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshTourBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTourBtn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupContainer.ResumeLayout(false);
            this.groupSearchPanel.ResumeLayout(false);
            this.groupSearchPanel.PerformLayout();
            this.groupTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTable)).EndInit();
            this.groupActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editGroupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshGroupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGroupBtn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.reportContainer.ResumeLayout(false);
            this.reportSearchPanel.ResumeLayout(false);
            this.reportSearchPanel.PerformLayout();
            this.reportTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.employeeContainer.ResumeLayout(false);
            this.employeeSearchPanel.ResumeLayout(false);
            this.employeeSearchPanel.PerformLayout();
            this.employeeTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.employeeActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshEmployeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tourContainer;
        private System.Windows.Forms.Panel tourSearchPanel;
        private System.Windows.Forms.Button resetTourBtn;
        private System.Windows.Forms.Button searchTourBtn;
        private System.Windows.Forms.TextBox nightTxt;
        private System.Windows.Forms.TextBox dayTxt;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.ComboBox districtCb;
        private System.Windows.Forms.ComboBox cityCb;
        private System.Windows.Forms.ComboBox tourTypeCb;
        private System.Windows.Forms.Label tourTypeLbl;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.TextBox tourNameTxt;
        private System.Windows.Forms.TextBox tourCodeTxt;
        private System.Windows.Forms.Label tourNameLbl;
        private System.Windows.Forms.Label tourCodeLbl;
        private System.Windows.Forms.TableLayoutPanel tourTablePanel;
        private System.Windows.Forms.DataGridView tourTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel groupContainer;
        private System.Windows.Forms.Panel groupSearchPanel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Button resetGroupBtn;
        private System.Windows.Forms.Button searchGroupBtn;
        private System.Windows.Forms.TextBox groupNameTxt;
        private System.Windows.Forms.TextBox groupCodeTxt;
        private System.Windows.Forms.Label groupNameLbl;
        private System.Windows.Forms.Label groupCodeLbl;
        private System.Windows.Forms.TableLayoutPanel groupTablePanel;
        private System.Windows.Forms.DataGridView groupTable;
        private System.Windows.Forms.Panel groupActionPanel;
        private System.Windows.Forms.PictureBox refreshGroupBtn;
        private System.Windows.Forms.PictureBox addGroupBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tourActionPanel;
        private System.Windows.Forms.PictureBox refreshTourBtn;
        private System.Windows.Forms.PictureBox addTourBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox priceToTxt;
        private System.Windows.Forms.TextBox priceFromTxt;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.PictureBox editTourBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourType;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Night;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewGroup;
        private System.Windows.Forms.PictureBox editGroupBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel reportContainer;
        private System.Windows.Forms.Panel reportSearchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.DateTimePicker reportToDatePicker;
        private System.Windows.Forms.DateTimePicker reportFromDatePicker;
        private System.Windows.Forms.Panel reportTablePanel;
        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel employeeContainer;
        private System.Windows.Forms.Panel employeeSearchPanel;
        private System.Windows.Forms.TableLayoutPanel employeeTablePanel;
        private System.Windows.Forms.Button resetEmployeeBtn;
        private System.Windows.Forms.Button searchEmployeeBtn;
        private System.Windows.Forms.Label employeeCodeLbl;
        private System.Windows.Forms.TextBox employeeCodeTxt;
        private System.Windows.Forms.TextBox employeeIdentityNumberTxt;
        private System.Windows.Forms.Label employeeIdentityNumberLbl;
        private System.Windows.Forms.TextBox employeeFirstNameTxt;
        private System.Windows.Forms.Label employeeFirstNameLbl;
        private System.Windows.Forms.TextBox employeeLastNameTxt;
        private System.Windows.Forms.Label employeeLastNameLbl;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Panel employeeActionPanel;
        private System.Windows.Forms.PictureBox editEmployeeBtn;
        private System.Windows.Forms.PictureBox refreshEmployeeBtn;
        private System.Windows.Forms.PictureBox addEmployeeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourOrGroupCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourOrGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourCodeOfGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}