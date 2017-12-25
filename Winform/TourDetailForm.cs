using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Winform
{
    public partial class TourDetailForm : MyCustomForm
    {
        GroupBIZ groupBIZ = new GroupBIZ();
        TourPriceHistoryBIZ tourPriceHistoryBIZ = new TourPriceHistoryBIZ();

        Tour tour = new Tour();

        public TourDetailForm(Tour tour)
        {
            InitializeComponent();

            this.Text = "Tour " + tour.Code + " - " + tour.Name;

            this.tour = tour;

            startDatePicker.Value = DateTime.Now.AddYears(-1);
            endDatePicker.Value = DateTime.Now.AddYears(1);

            groupTable.Columns[9].Width = 40;

            RefreshGroup(groupBIZ.GetByTourID(tour.ID));
            RefreshLocation(tourLocationBIZ.GetByTourID(tour.ID));
            RefreshTourPrice(tourPriceHistoryBIZ.GetByTourID(tour.ID));
        }

        public void RefreshGroup(List<Group> groups)
        {
            groupTable.Rows.Clear();

            foreach (var t in groups)
            {
                groupTable.Rows.Add(
                    t.ID,
                    t.Code,
                    t.Name,
                    t.StartDate,
                    t.EndDate,
                    t.PickupLocation,
                    t.DropLocation,
                    t.Description,
                    t.Policy,
                    "Chi tiết"
                );
                if(t.StartDate < DateTime.Now)
                    groupTable.Rows[groupTable.RowCount - 2].DefaultCellStyle.ForeColor = Color.Gray;
            }
        }

        private void refreshGroupBtn_Click(object sender, EventArgs e)
        {
            groupBIZ = new GroupBIZ(); 
            RefreshGroup(groupBIZ.GetByTourID(this.tour.ID));
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddGroupForm"] as AddGroupForm) == null)
            {
                AddGroupForm addGroupForm = new AddGroupForm(tour);
                addGroupForm.Show();
            }
        }

        // edit group info when click on edit icon
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

        // edit group info when double click on cell (except last cell)
        private void groupTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["EditGroupForm"] as EditGroupForm) == null)
            {
                if (e.ColumnIndex != 9 && e.RowIndex >= 0)
                {
                    int groupID = Convert.ToInt32(
                    groupTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                    EditGroupForm editGroupForm = new EditGroupForm(groupID);
                    editGroupForm.Show();
                }
            }
        }

        private void viewGroupDetails(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["GroupDetailForm"] as GroupDetailForm) == null)
            {
                if (e.ColumnIndex == 9 && e.RowIndex >= 0)
                {
                    int groupID = Convert.ToInt32(groupTable.Rows[e.RowIndex]
                        .Cells[0].Value.ToString());
                    groupBIZ = new GroupBIZ();
                    GroupDetailForm groupDetailForm = new GroupDetailForm(groupBIZ.GetByID(groupID));
                    groupDetailForm.Show();

                }
            }          

        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            if ((Application.OpenForms["GroupDetailForm"] as GroupDetailForm) != null)
                Application.OpenForms["GroupDetailForm"].Close();
        }

        private void searchGroupBtn_Click(object sender, EventArgs e)
        {
            string code = groupCodeTxt.Text;
            string name = groupNameTxt.Text;
            DateTime startDate = Convert.ToDateTime(startDatePicker.Value.ToString());
            DateTime endDate = Convert.ToDateTime(endDatePicker.Value.ToString());

            groupBIZ = new GroupBIZ();
            var result = groupBIZ.Find(code, name, startDate, endDate);

            RefreshGroup(result);
        }

        // reset group's search form
        private void resetGroupBtn_Click(object sender, EventArgs e)
        {
            groupCodeTxt.Text = "";
            groupNameTxt.Text = "";
            startDatePicker.Value = DateTime.Now.AddYears(-1);
            endDatePicker.Value = DateTime.Now.AddYears(1);

            groupBIZ = new GroupBIZ();
            RefreshGroup(groupBIZ.GetAll());
        }
        
    }
}
