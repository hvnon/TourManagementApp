namespace Winform
{
    partial class TourDetailForm
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
            this.groupContainerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupTablePanel = new System.Windows.Forms.Panel();
            this.groupTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupActionPanel = new System.Windows.Forms.Panel();
            this.editGroupBtn = new System.Windows.Forms.PictureBox();
            this.refreshGroupBtn = new System.Windows.Forms.PictureBox();
            this.addGroupBtn = new System.Windows.Forms.PictureBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.locationContainerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.locationTablePanel = new System.Windows.Forms.Panel();
            this.locationTable = new System.Windows.Forms.DataGridView();
            this.tourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationActionPanel = new System.Windows.Forms.Panel();
            this.deleteLocationBtn = new System.Windows.Forms.PictureBox();
            this.editLocationBtn = new System.Windows.Forms.PictureBox();
            this.refreshLocationBtn = new System.Windows.Forms.PictureBox();
            this.addLocationBtn = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupContainerPanel.SuspendLayout();
            this.groupTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTable)).BeginInit();
            this.groupActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editGroupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshGroupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGroupBtn)).BeginInit();
            this.groupSearchPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.locationContainerPanel.SuspendLayout();
            this.locationTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTable)).BeginInit();
            this.locationActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteLocationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLocationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshLocationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLocationBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(779, 600);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.refreshLocationBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupContainerPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách đoàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupContainerPanel
            // 
            this.groupContainerPanel.ColumnCount = 1;
            this.groupContainerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupContainerPanel.Controls.Add(this.groupTablePanel, 0, 2);
            this.groupContainerPanel.Controls.Add(this.groupActionPanel, 0, 1);
            this.groupContainerPanel.Controls.Add(this.groupSearchPanel, 0, 0);
            this.groupContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.groupContainerPanel.Name = "groupContainerPanel";
            this.groupContainerPanel.RowCount = 3;
            this.groupContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.groupContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.16397F));
            this.groupContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.83603F));
            this.groupContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.groupContainerPanel.Size = new System.Drawing.Size(765, 568);
            this.groupContainerPanel.TabIndex = 0;
            // 
            // groupTablePanel
            // 
            this.groupTablePanel.Controls.Add(this.groupTable);
            this.groupTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTablePanel.Location = new System.Drawing.Point(3, 234);
            this.groupTablePanel.Name = "groupTablePanel";
            this.groupTablePanel.Size = new System.Drawing.Size(759, 331);
            this.groupTablePanel.TabIndex = 0;
            // 
            // groupTable
            // 
            this.groupTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Code,
            this.GroupName,
            this.StartDate,
            this.EndDate,
            this.PickupLocation,
            this.DropLocation,
            this.Description,
            this.Policy,
            this.ViewGroup});
            this.groupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTable.Location = new System.Drawing.Point(0, 0);
            this.groupTable.Name = "groupTable";
            this.groupTable.Size = new System.Drawing.Size(759, 331);
            this.groupTable.TabIndex = 6;
            this.groupTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGroupDetails);
            this.groupTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupTable_CellDoubleClick);
            this.groupTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.groupTable_CellMouseMove);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Code
            // 
            this.Code.HeaderText = "Mã đoàn";
            this.Code.Name = "Code";
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
            // Description
            // 
            this.Description.HeaderText = "Hành trình";
            this.Description.Name = "Description";
            // 
            // Policy
            // 
            this.Policy.HeaderText = "Chính sách";
            this.Policy.Name = "Policy";
            // 
            // ViewGroup
            // 
            this.ViewGroup.HeaderText = "";
            this.ViewGroup.Name = "ViewGroup";
            // 
            // groupActionPanel
            // 
            this.groupActionPanel.Controls.Add(this.editGroupBtn);
            this.groupActionPanel.Controls.Add(this.refreshGroupBtn);
            this.groupActionPanel.Controls.Add(this.addGroupBtn);
            this.groupActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupActionPanel.Location = new System.Drawing.Point(3, 184);
            this.groupActionPanel.Name = "groupActionPanel";
            this.groupActionPanel.Size = new System.Drawing.Size(759, 44);
            this.groupActionPanel.TabIndex = 1;
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editGroupBtn.Image = global::Winform.Properties.Resources.edit;
            this.editGroupBtn.Location = new System.Drawing.Point(437, 9);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(28, 26);
            this.editGroupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editGroupBtn.TabIndex = 9;
            this.editGroupBtn.TabStop = false;
            this.editGroupBtn.Click += new System.EventHandler(this.editGroupBtn_Click);
            // 
            // refreshGroupBtn
            // 
            this.refreshGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshGroupBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshGroupBtn.Location = new System.Drawing.Point(341, 9);
            this.refreshGroupBtn.Name = "refreshGroupBtn";
            this.refreshGroupBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshGroupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshGroupBtn.TabIndex = 5;
            this.refreshGroupBtn.TabStop = false;
            this.refreshGroupBtn.Click += new System.EventHandler(this.refreshGroupBtn_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGroupBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addGroupBtn.Location = new System.Drawing.Point(389, 9);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(28, 26);
            this.addGroupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addGroupBtn.TabIndex = 4;
            this.addGroupBtn.TabStop = false;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
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
            this.groupSearchPanel.Location = new System.Drawing.Point(3, 3);
            this.groupSearchPanel.MinimumSize = new System.Drawing.Size(760, 175);
            this.groupSearchPanel.Name = "groupSearchPanel";
            this.groupSearchPanel.Size = new System.Drawing.Size(760, 175);
            this.groupSearchPanel.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDatePicker.Location = new System.Drawing.Point(485, 75);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(165, 20);
            this.endDatePicker.TabIndex = 44;
            // 
            // endDateLbl
            // 
            this.endDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(411, 75);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(47, 13);
            this.endDateLbl.TabIndex = 43;
            this.endDateLbl.Text = "Ngày về";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDatePicker.Location = new System.Drawing.Point(197, 75);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(165, 20);
            this.startDatePicker.TabIndex = 42;
            this.startDatePicker.Value = new System.DateTime(2017, 11, 27, 0, 0, 0, 0);
            // 
            // startDateLbl
            // 
            this.startDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(111, 75);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(44, 13);
            this.startDateLbl.TabIndex = 41;
            this.startDateLbl.Text = "Ngày đi";
            // 
            // resetGroupBtn
            // 
            this.resetGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetGroupBtn.Location = new System.Drawing.Point(497, 126);
            this.resetGroupBtn.Name = "resetGroupBtn";
            this.resetGroupBtn.Size = new System.Drawing.Size(67, 27);
            this.resetGroupBtn.TabIndex = 40;
            this.resetGroupBtn.Text = "Hủy";
            this.resetGroupBtn.UseVisualStyleBackColor = true;
            this.resetGroupBtn.Click += new System.EventHandler(this.resetGroupBtn_Click);
            // 
            // searchGroupBtn
            // 
            this.searchGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchGroupBtn.Location = new System.Drawing.Point(583, 126);
            this.searchGroupBtn.Name = "searchGroupBtn";
            this.searchGroupBtn.Size = new System.Drawing.Size(67, 27);
            this.searchGroupBtn.TabIndex = 39;
            this.searchGroupBtn.Text = "Tìm";
            this.searchGroupBtn.UseVisualStyleBackColor = true;
            this.searchGroupBtn.Click += new System.EventHandler(this.searchGroupBtn_Click);
            // 
            // groupNameTxt
            // 
            this.groupNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameTxt.Location = new System.Drawing.Point(485, 22);
            this.groupNameTxt.Name = "groupNameTxt";
            this.groupNameTxt.Size = new System.Drawing.Size(165, 20);
            this.groupNameTxt.TabIndex = 38;
            // 
            // groupCodeTxt
            // 
            this.groupCodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupCodeTxt.Location = new System.Drawing.Point(197, 22);
            this.groupCodeTxt.Name = "groupCodeTxt";
            this.groupCodeTxt.Size = new System.Drawing.Size(165, 20);
            this.groupCodeTxt.TabIndex = 37;
            // 
            // groupNameLbl
            // 
            this.groupNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupNameLbl.AutoSize = true;
            this.groupNameLbl.Location = new System.Drawing.Point(411, 25);
            this.groupNameLbl.Name = "groupNameLbl";
            this.groupNameLbl.Size = new System.Drawing.Size(54, 13);
            this.groupNameLbl.TabIndex = 36;
            this.groupNameLbl.Text = "Tên đoàn";
            // 
            // groupCodeLbl
            // 
            this.groupCodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupCodeLbl.AutoSize = true;
            this.groupCodeLbl.Location = new System.Drawing.Point(111, 25);
            this.groupCodeLbl.Name = "groupCodeLbl";
            this.groupCodeLbl.Size = new System.Drawing.Size(50, 13);
            this.groupCodeLbl.TabIndex = 35;
            this.groupCodeLbl.Text = "Mã đoàn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.locationContainerPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách địa điểm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationContainerPanel
            // 
            this.locationContainerPanel.ColumnCount = 1;
            this.locationContainerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.locationContainerPanel.Controls.Add(this.locationTablePanel, 0, 1);
            this.locationContainerPanel.Controls.Add(this.locationActionPanel, 0, 0);
            this.locationContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.locationContainerPanel.Name = "locationContainerPanel";
            this.locationContainerPanel.RowCount = 2;
            this.locationContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.locationContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.locationContainerPanel.Size = new System.Drawing.Size(765, 568);
            this.locationContainerPanel.TabIndex = 1;
            // 
            // locationTablePanel
            // 
            this.locationTablePanel.Controls.Add(this.locationTable);
            this.locationTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTablePanel.Location = new System.Drawing.Point(3, 48);
            this.locationTablePanel.Name = "locationTablePanel";
            this.locationTablePanel.Size = new System.Drawing.Size(759, 517);
            this.locationTablePanel.TabIndex = 0;
            // 
            // locationTable
            // 
            this.locationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.locationTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourID,
            this.locationID,
            this.no,
            this.name,
            this.city,
            this.district});
            this.locationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTable.Location = new System.Drawing.Point(0, 0);
            this.locationTable.Name = "locationTable";
            this.locationTable.Size = new System.Drawing.Size(759, 517);
            this.locationTable.TabIndex = 5;
            this.locationTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locationTable_CellDoubleClick);
            // 
            // tourID
            // 
            this.tourID.HeaderText = "TourID";
            this.tourID.Name = "tourID";
            this.tourID.Visible = false;
            // 
            // locationID
            // 
            this.locationID.HeaderText = "LocationID";
            this.locationID.Name = "locationID";
            this.locationID.Visible = false;
            // 
            // no
            // 
            this.no.HeaderText = "STT";
            this.no.Name = "no";
            // 
            // name
            // 
            this.name.HeaderText = "Tên địa điểm";
            this.name.Name = "name";
            // 
            // city
            // 
            this.city.HeaderText = "Tỉnh/thành";
            this.city.Name = "city";
            // 
            // district
            // 
            this.district.HeaderText = "Quận/huyện";
            this.district.Name = "district";
            // 
            // locationActionPanel
            // 
            this.locationActionPanel.Controls.Add(this.deleteLocationBtn);
            this.locationActionPanel.Controls.Add(this.editLocationBtn);
            this.locationActionPanel.Controls.Add(this.refreshLocationBtn);
            this.locationActionPanel.Controls.Add(this.addLocationBtn);
            this.locationActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationActionPanel.Location = new System.Drawing.Point(3, 3);
            this.locationActionPanel.Name = "locationActionPanel";
            this.locationActionPanel.Size = new System.Drawing.Size(759, 39);
            this.locationActionPanel.TabIndex = 1;
            // 
            // deleteLocationBtn
            // 
            this.deleteLocationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteLocationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLocationBtn.Image = global::Winform.Properties.Resources.Trash_Recyclebin_Empty_Closed;
            this.deleteLocationBtn.Location = new System.Drawing.Point(466, 4);
            this.deleteLocationBtn.Name = "deleteLocationBtn";
            this.deleteLocationBtn.Size = new System.Drawing.Size(31, 30);
            this.deleteLocationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteLocationBtn.TabIndex = 9;
            this.deleteLocationBtn.TabStop = false;
            this.deleteLocationBtn.Click += new System.EventHandler(this.deleteLocation_BtnClick);
            // 
            // editLocationBtn
            // 
            this.editLocationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editLocationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLocationBtn.Image = global::Winform.Properties.Resources.edit;
            this.editLocationBtn.Location = new System.Drawing.Point(413, 6);
            this.editLocationBtn.Name = "editLocationBtn";
            this.editLocationBtn.Size = new System.Drawing.Size(28, 26);
            this.editLocationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editLocationBtn.TabIndex = 8;
            this.editLocationBtn.TabStop = false;
            this.editLocationBtn.Click += new System.EventHandler(this.editLocationBtn_Click);
            // 
            // refreshLocationBtn
            // 
            this.refreshLocationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshLocationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshLocationBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshLocationBtn.Location = new System.Drawing.Point(314, 6);
            this.refreshLocationBtn.Name = "refreshLocationBtn";
            this.refreshLocationBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshLocationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshLocationBtn.TabIndex = 7;
            this.refreshLocationBtn.TabStop = false;
            this.refreshLocationBtn.Click += new System.EventHandler(this.refreshLocationBtn_Click);
            // 
            // addLocationBtn
            // 
            this.addLocationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addLocationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLocationBtn.Image = global::Winform.Properties.Resources.app_type_pharmacy_512px_GREY;
            this.addLocationBtn.Location = new System.Drawing.Point(362, 6);
            this.addLocationBtn.Name = "addLocationBtn";
            this.addLocationBtn.Size = new System.Drawing.Size(28, 26);
            this.addLocationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addLocationBtn.TabIndex = 6;
            this.addLocationBtn.TabStop = false;
            this.addLocationBtn.Click += new System.EventHandler(this.addLocationBtn_Click);
            // 
            // TourDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(779, 600);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(795, 525);
            this.Name = "TourDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết tour";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupContainerPanel.ResumeLayout(false);
            this.groupTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTable)).EndInit();
            this.groupActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editGroupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshGroupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGroupBtn)).EndInit();
            this.groupSearchPanel.ResumeLayout(false);
            this.groupSearchPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.locationContainerPanel.ResumeLayout(false);
            this.locationTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationTable)).EndInit();
            this.locationActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteLocationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLocationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshLocationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLocationBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel groupContainerPanel;
        private System.Windows.Forms.Panel groupTablePanel;
        private System.Windows.Forms.DataGridView groupTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewGroup;
        private System.Windows.Forms.Panel groupActionPanel;
        private System.Windows.Forms.PictureBox refreshGroupBtn;
        private System.Windows.Forms.PictureBox addGroupBtn;
        private System.Windows.Forms.TableLayoutPanel locationContainerPanel;
        private System.Windows.Forms.Panel locationTablePanel;
        private System.Windows.Forms.DataGridView locationTable;
        private System.Windows.Forms.Panel locationActionPanel;
        private System.Windows.Forms.PictureBox refreshLocationBtn;
        private System.Windows.Forms.PictureBox addLocationBtn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tourID;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.PictureBox editLocationBtn;
        private System.Windows.Forms.PictureBox deleteLocationBtn;
        private System.Windows.Forms.PictureBox editGroupBtn;
    }
}