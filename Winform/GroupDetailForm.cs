using System;
using System.Collections.Generic;
using System.Drawing;

using DAL.Entities;
using BIZ;

using System.Windows.Forms;

namespace Winform
{
    public partial class GroupDetailForm : Form
    {
        GroupFeeBIZ groupFeeBIZ = new GroupFeeBIZ();
        CustomerGroupBIZ customerGroupBIZ = new CustomerGroupBIZ();

        Group group = new Group();

        public GroupDetailForm(Group group)
        {
            InitializeComponent();

            this.group = group;

            this.Text = group.Code + " - " + group.Name;

            feeTable.Columns["Price"].DefaultCellStyle.Format = "#,0.###";
            feeTable.Columns["SubTotal"].DefaultCellStyle.Format = "#,0.###";

            var customers = customerGroupBIZ.GetByGroupID(group.ID);

            int numberOfCustomer = customers.Count;
            feeTable.Columns["SubTotal"].HeaderText = "Thành tiền (" 
                + numberOfCustomer + " khách)";

            RefreshFeeForm(groupFeeBIZ.GetByGroupID(group.ID), numberOfCustomer);
            RefreshCustomerForm(customers);
        }

        public void RefreshFeeForm(List<GroupFee> groupFees, int numberOfCustomer)
        {
            feeTable.Rows.Clear();

            if (groupFees.Count <= 0) return;

            int feeType = groupFees[0].FeeTypeID, total = 0, subTotal = 0;
            int i, count = groupFees.Count;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(feeTable.Font, FontStyle.Bold);
            style.ForeColor = Color.Blue;

            for (i = 0; i < count; i++)
            {
                total += groupFees[i].Price;

                if (groupFees[i].FeeTypeID == feeType)
                {
                    subTotal += groupFees[i].Price * numberOfCustomer;
                }
                else
                {
                    feeTable.Rows.Add(
                            "",
                            "",
                            "",
                            "",
                            subTotal
                            );
                    feeTable.Rows[feeTable.RowCount - 2].DefaultCellStyle = style;

                    feeType = groupFees[i].FeeTypeID;
                    subTotal = groupFees[i].Price * numberOfCustomer;
                }

                feeTable.Rows.Add(
                    groupFees[i].ID,
                    groupFees[i].FeeType.Name,
                    groupFees[i].Description,
                    groupFees[i].Price,
                    groupFees[i].Price * numberOfCustomer
                );

            }
            feeTable.Rows.Add(
                "",
                "",
                "",
                "",
                subTotal
                );
            feeTable.Rows[feeTable.RowCount-2].DefaultCellStyle = style;
            feeTable.Rows.Add(
                "",
                "",
                "",
                "Tổng chi phí:",
                total * numberOfCustomer
                );
            feeTable.Rows[feeTable.RowCount - 2].DefaultCellStyle.Font = new
               Font("Arial", 11, FontStyle.Bold);
            feeTable.Rows[feeTable.RowCount - 2].DefaultCellStyle.ForeColor = Color.DeepPink;
        }

        private void refreshFeeBtn_Click(object sender, EventArgs e)
        {
            groupFeeBIZ = new GroupFeeBIZ();

            customerGroupBIZ = new CustomerGroupBIZ();
            var customers = customerGroupBIZ.GetByGroupID(this.group.ID);
            int numberOfCustomer = customers.Count;

            RefreshFeeForm(groupFeeBIZ.GetByGroupID(this.group.ID), numberOfCustomer);
        }

        public void RefreshCustomerForm(List<CustomerGroup> customerGroup)
        {
            customerTable.Rows.Clear();

            for (var i = 0; i < customerGroup.Count; i++)
            {
                string gender;
                if (customerGroup[i].Customer.Gender == true)
                    gender = "Nam";
                else gender = "Nữ";
                customerTable.Rows.Add(
                    customerGroup[i].Customer.ID,
                    customerGroup[i].Customer.Code,
                    customerGroup[i].Customer.LastName,
                    customerGroup[i].Customer.FirstName,
                    customerGroup[i].Customer.IdentityNumber,
                    customerGroup[i].Customer.Phone,
                    customerGroup[i].Customer.Address,
                    customerGroup[i].Customer.BirthDate,
                    gender
                );
            }
        }

        private void refreshCustomerBtn_Click(object sender, EventArgs e)
        {
            customerGroupBIZ = new CustomerGroupBIZ();
            RefreshCustomerForm(customerGroupBIZ.GetByGroupID(this.group.ID));
        }

        private void addFeeBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddGroupFeeForm"] as AddGroupFeeForm) == null)
            {
                AddGroupFeeForm addGroupFeeForm = new AddGroupFeeForm(this.group.ID);
                addGroupFeeForm.Show();
            }
        }

        private void deleteFeeBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa chi phí này?",
                "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int rowIndex = feeTable.CurrentCell.RowIndex;

                if (rowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                    feeTable.Rows[rowIndex].Cells[0].Value.ToString());
                    
                    groupFeeBIZ.Delete(id);

                    groupFeeBIZ = new GroupFeeBIZ();
                    customerGroupBIZ = new CustomerGroupBIZ();
                    var customers = customerGroupBIZ.GetByGroupID(group.ID);

                    int numberOfCustomer = customers.Count;

                    RefreshFeeForm(groupFeeBIZ.GetByGroupID(group.ID), numberOfCustomer);
                }

            }
        }
    }
}
