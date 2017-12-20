using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;

namespace Winform
{
    public partial class TourDetailForm : MyCustomForm
    {
        TourLocationBIZ tourLocationBIZ = new TourLocationBIZ();

        public void RefreshLocation(List<TourLocation> tourLocations)
        {
            locationTable.Rows.Clear();

            for (int i = 0; i < tourLocations.Count; i++)
            {
                locationTable.Rows.Add(
                    tourLocations[i].TourID,
                    tourLocations[i].LocationID,
                    i + 1,
                    tourLocations[i].Location.Name,
                    tourLocations[i].Location.City.Name,
                    tourLocations[i].Location.District.Name
                );
            }
        }

        private void refreshLocationBtn_Click(object sender, EventArgs e)
        {
            tourLocationBIZ = new TourLocationBIZ();
            RefreshLocation(tourLocationBIZ.GetByTourID(tour.ID));
        }

        private void addLocationBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddTourLocationForm"] as AddTourLocationForm) == null)
            {
                AddTourLocationForm addTourLocationForm = new AddTourLocationForm(this.tour);
                addTourLocationForm.Show();
            }
        }

        private void editLocationBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["EditTourLocationForm"] as EditTourLocationForm) == null)
            {
                int rowIndex = locationTable.CurrentCell.RowIndex;

                if (rowIndex >= 0)
                {
                    int locationID = Convert.ToInt32(
                    locationTable.Rows[rowIndex].Cells[1].Value.ToString());
                    TourLocation t = new TourLocation()
                    {
                        TourID = this.tour.ID,
                        LocationID = locationID
                    };
                    EditTourLocationForm editTourLocationForm = new EditTourLocationForm(t);
                    editTourLocationForm.Show();
                }

            }

        }

        private void locationTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["EditTourLocationForm"] as EditTourLocationForm) == null)
            {
                if (e.RowIndex >= 0)
                {
                    int locationID = Convert.ToInt32(
                    locationTable.Rows[e.RowIndex].Cells[1].Value.ToString());
                    TourLocation t = new TourLocation()
                    {
                        TourID = this.tour.ID,
                        LocationID = locationID
                    };
                    EditTourLocationForm editTourLocationForm = new EditTourLocationForm(t);
                    editTourLocationForm.Show();
                }

            }
        }

        private void deleteLocation_BtnClick(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa địa điểm này?",
                "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int rowIndex = locationTable.CurrentCell.RowIndex;

                if (rowIndex >= 0)
                {
                    int locationID = Convert.ToInt32(
                    locationTable.Rows[rowIndex].Cells[1].Value.ToString());
                    TourLocation tourLocation = new TourLocation()
                    {
                        TourID = tour.ID,
                        LocationID = locationID
                    };
                    tourLocationBIZ.Delete(tourLocation);

                    tourLocationBIZ = new TourLocationBIZ();
                    RefreshLocation(tourLocationBIZ.GetByTourID(tour.ID));
                }

            }

        }

        private void groupTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 9)
                groupTable.Cursor = Cursors.Hand;
            else
                groupTable.Cursor = Cursors.Default;
        }

    }
}
