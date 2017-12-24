using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Winform
{
    public partial class GroupDetailForm : MyCustomForm
    {
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
            feeTable.Rows[feeTable.RowCount - 2].DefaultCellStyle = style;
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
