using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Winform
{
    public partial class MainForm : MyCustomForm
    {
        GroupBIZ groupBIZ = new GroupBIZ();
        GroupFeeBIZ groupFeeBIZ = new GroupFeeBIZ();

        public void InitializeGroupForm()
        {
            startDatePicker.Value = DateTime.Now.AddYears(-1);
            endDatePicker.Value = DateTime.Now.AddYears(1);

            groupTable.Columns[10].Width = 40;
        }

        public void RefreshGroupForm(List<Group> groups)
        {
            groupTable.Rows.Clear();

            foreach (var t in groups)
            {
                groupTable.Rows.Add(
                    t.ID,
                    t.Code,
                    t.Tour.Code,
                    t.Name,
                    t.StartDate,
                    t.EndDate,
                    t.PickupLocation,
                    t.DropLocation,
                    t.Description,
                    t.Policy,
                    "Chi tiết"
                );
                if (t.StartDate < DateTime.Now)
                    groupTable.Rows[groupTable.RowCount - 1].DefaultCellStyle.ForeColor = Color.Gray;
            }

        }

        private void searchGroupBtn_Click(object sender, EventArgs e)
        {
            string code = groupCodeTxt.Text;
            string name = groupNameTxt.Text;
            DateTime startDate = Convert.ToDateTime(startDatePicker.Value.ToString());
            DateTime endDate = Convert.ToDateTime(endDatePicker.Value.ToString());

            var result = groupBIZ.Find(code, name, startDate, endDate);

            RefreshGroupForm(result);
        }

        private void resetGroupBtn_Click(object sender, EventArgs e)
        {
            groupCodeTxt.Text = "";
            groupNameTxt.Text = "";
            startDatePicker.Value = DateTime.Now.AddYears(-1);
            endDatePicker.Value = DateTime.Now.AddYears(1);
            RefreshGroupForm(groupBIZ.GetAll());
        }

        private void refreshGroupBtn_Click(object sender, EventArgs e)
        {
            groupBIZ = new GroupBIZ();
            RefreshGroupForm(groupBIZ.GetAll());
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddGroupForm"] as AddGroupForm) == null)
            {
                AddGroupForm addGroupForm = new AddGroupForm(null);
                addGroupForm.Show();
            }
        }

        private void viewGroupDetails(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["GroupDetailForm"] as GroupDetailForm) == null)
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0)
                {
                    int groupID = Convert.ToInt32(groupTable.Rows[e.RowIndex]
                        .Cells[0].Value.ToString());
                    GroupDetailForm groupDetailForm = new GroupDetailForm(groupBIZ.GetByID(groupID));
                    groupDetailForm.Show();

                }
            }

        }

        private void groupTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["EditGroupForm"] as EditGroupForm) == null)
            {
                if (e.ColumnIndex != 10 && e.RowIndex >= 0)
                {
                    int groupID = Convert.ToInt32(
                    groupTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                    EditGroupForm editGroupForm = new EditGroupForm(groupID);
                    editGroupForm.Show();
                }
            }
        }

        private void editGroupBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["EditGroupForm"] as EditGroupForm) == null)
            {
                int rowIndex = groupTable.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    int groupID = Convert.ToInt32(
                    groupTable.Rows[rowIndex].Cells[0].Value.ToString());
                    EditGroupForm editGroupForm = new EditGroupForm(groupID);
                    editGroupForm.Show();
                }
            }
        }

        private void groupTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 10)
                groupTable.Cursor = Cursors.Hand;
            else
                groupTable.Cursor = Cursors.Default;
        }
       
    }
}
