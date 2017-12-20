using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class EditTourLocationForm : Form
    {
        LocationBIZ locationBIZ = new LocationBIZ();
        TourLocationBIZ tourLocationBIZ = new TourLocationBIZ();
        TourBIZ tourBIZ = new TourBIZ();
        TourLocation tourLocation;

        public EditTourLocationForm(TourLocation tourLocation)
        {
            InitializeComponent();

            this.tourLocation = tourLocation;

            var tour = tourBIZ.GetByID(tourLocation.TourID);
            this.Text = "Cập nhật địa điểm cho tour " + tour.Code + "-" + tour.Name;

            this.tourLocation = tourLocation;

            var locations = locationBIZ.GetAll();

            locationCb.DataSource = locations;
            locationCb.ValueMember = "ID";
            locationCb.DisplayMember = "Name";
            locationCb.SelectedValue = tourLocationBIZ.CheckIfExisted(tourLocation).LocationID;
        }

        private void editLocationBtn_Click(object sender, EventArgs e)
        {
            TourLocation t = new TourLocation()
            {
                TourID = this.tourLocation.TourID,
                LocationID = Convert.ToInt32(locationCb.SelectedValue)
            };
            if (tourLocationBIZ.CheckIfExisted(t) != null)
            {
                MessageBox.Show("Địa điểm đã tồn tại!");
                return;
            }
            else
            {
                tourLocationBIZ.Update(t, this.tourLocation.LocationID);

                MessageBox.Show("Sửa thành công!");

                var tourDetailForm = Application.OpenForms.OfType<TourDetailForm>().Single();
                tourDetailForm.RefreshLocation(tourLocationBIZ.GetByTourID(this.tourLocation.TourID));
            }
        }
    }
}
