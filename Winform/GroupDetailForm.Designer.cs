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
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.deleteFeeBtn = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.customerContainerPanel.SuspendLayout();
            this.customerTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.customerActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCustomerBtn)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.feeTableContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeTable)).BeginInit();
            this.feeActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshFeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFeeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFeeBtn)).BeginInit();
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
            this.customerContainerPanel.Controls.Add(this.customerTablePanel, 0, 1);
            this.customerContainerPanel.Controls.Add(this.customerActionPanel, 0, 0);
            this.customerContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.customerContainerPanel.Name = "customerContainerPanel";
            this.customerContainerPanel.RowCount = 2;
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.72818F));
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.27182F));
            this.customerContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customerContainerPanel.Size = new System.Drawing.Size(802, 401);
            this.customerContainerPanel.TabIndex = 1;
            // 
            // customerTablePanel
            // 
            this.customerTablePanel.Controls.Add(this.customerTable);
            this.customerTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTablePanel.Location = new System.Drawing.Point(3, 38);
            this.customerTablePanel.Name = "customerTablePanel";
            this.customerTablePanel.Size = new System.Drawing.Size(796, 360);
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
            this.customerTable.Size = new System.Drawing.Size(796, 360);
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
            this.customerActionPanel.Location = new System.Drawing.Point(3, 3);
            this.customerActionPanel.Name = "customerActionPanel";
            this.customerActionPanel.Size = new System.Drawing.Size(796, 29);
            this.customerActionPanel.TabIndex = 1;
            // 
            // refreshCustomerBtn
            // 
            this.refreshCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshCustomerBtn.Image = global::Winform.Properties.Resources._585e4831cb11b227491c338e;
            this.refreshCustomerBtn.Location = new System.Drawing.Point(400, 2);
            this.refreshCustomerBtn.Name = "refreshCustomerBtn";
            this.refreshCustomerBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshCustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshCustomerBtn.TabIndex = 5;
            this.refreshCustomerBtn.TabStop = false;
            this.refreshCustomerBtn.Click += new System.EventHandler(this.refreshCustomerBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.feeActionPanel.Controls.Add(this.deleteFeeBtn);
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
            this.addFeeBtn.Click += new System.EventHandler(this.addFeeBtn_Click);
            // 
            // deleteFeeBtn
            // 
            this.deleteFeeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteFeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFeeBtn.Image = global::Winform.Properties.Resources.Trash_Recyclebin_Empty_Closed;
            this.deleteFeeBtn.Location = new System.Drawing.Point(463, 4);
            this.deleteFeeBtn.Name = "deleteFeeBtn";
            this.deleteFeeBtn.Size = new System.Drawing.Size(31, 30);
            this.deleteFeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteFeeBtn.TabIndex = 10;
            this.deleteFeeBtn.TabStop = false;
            this.deleteFeeBtn.Click += new System.EventHandler(this.deleteFeeBtn_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.feeTableContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feeTable)).EndInit();
            this.feeActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshFeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFeeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFeeBtn)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.PictureBox deleteFeeBtn;
    }
}