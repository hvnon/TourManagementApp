namespace Winform
{
    partial class EmployeeReportForm
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
            this.employeeReportContainer = new System.Windows.Forms.Panel();
            this.employeeReportTable = new System.Windows.Forms.DataGridView();
            this.GroupCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeReportContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeReportContainer
            // 
            this.employeeReportContainer.Controls.Add(this.employeeReportTable);
            this.employeeReportContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeReportContainer.Location = new System.Drawing.Point(0, 0);
            this.employeeReportContainer.Name = "employeeReportContainer";
            this.employeeReportContainer.Size = new System.Drawing.Size(958, 325);
            this.employeeReportContainer.TabIndex = 0;
            // 
            // employeeReportTable
            // 
            this.employeeReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeReportTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeReportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupCode,
            this.TourCode,
            this.GroupName,
            this.StartDate,
            this.EndDate,
            this.PickupPlace,
            this.DropPlace,
            this.Description,
            this.Policy});
            this.employeeReportTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeReportTable.Location = new System.Drawing.Point(0, 0);
            this.employeeReportTable.Name = "employeeReportTable";
            this.employeeReportTable.Size = new System.Drawing.Size(958, 325);
            this.employeeReportTable.TabIndex = 1;
            // 
            // GroupCode
            // 
            this.GroupCode.HeaderText = "Mã đoàn";
            this.GroupCode.Name = "GroupCode";
            this.GroupCode.ReadOnly = true;
            // 
            // TourCode
            // 
            this.TourCode.HeaderText = "Mã tour";
            this.TourCode.Name = "TourCode";
            this.TourCode.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Tên đoàn";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Ngày đi";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Ngày về";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // PickupPlace
            // 
            this.PickupPlace.HeaderText = "Địa điểm rước";
            this.PickupPlace.Name = "PickupPlace";
            this.PickupPlace.ReadOnly = true;
            // 
            // DropPlace
            // 
            this.DropPlace.HeaderText = "Địa điểm thả";
            this.DropPlace.Name = "DropPlace";
            this.DropPlace.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Hành trình";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Policy
            // 
            this.Policy.HeaderText = "Chính sách";
            this.Policy.Name = "Policy";
            this.Policy.ReadOnly = true;
            // 
            // EmployeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 325);
            this.Controls.Add(this.employeeReportContainer);
            this.Name = "EmployeeReportForm";
            this.Text = "Thống kê đoàn đã đi";
            this.employeeReportContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeReportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeeReportContainer;
        private System.Windows.Forms.DataGridView employeeReportTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policy;
    }
}