using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class AddTourLocationForm : Form
    {
        LocationBIZ locationBIZ = new LocationBIZ();
        TourLocationBIZ tourLocationBIZ = new TourLocationBIZ();
        Tour tour;

        public AddTourLocationForm(Tour tour)
        {
            InitializeComponent();
            this.Text = "Thêm địa điểm cho tour " + tour.Code + "-" + tour.Name;

            this.tour = tour;

            var locations = locationBIZ.GetAll();

            locations.Insert(0, new Location() { ID = -1, Name = "------ Chọn địa điểm -----" });

            locationCb.DataSource = locations;
            locationCb.ValueMember = "ID";
            locationCb.DisplayMember = "Name";
        }

        private void addLocationBtn_Click(object sender, EventArgs e)
        {
            int locationID = locationCb.SelectedIndex;
            if (locationID == 0)
            {
                MessageBox.Show("Vui lòng chọn địa điểm!");
                return;
            }
            TourLocation t = new TourLocation()
            {
                TourID = this.tour.ID,
                LocationID = locationID
            };
            if (tourLocationBIZ.CheckIfExisted(t) != null)
            {
                MessageBox.Show("Địa điểm đã tồn tại!");
                return;
            }
   
            tourLocationBIZ.Add(t);

            MessageBox.Show("Thêm địa điểm thành công");

            var tourDetailForm = Application.OpenForms.OfType<TourDetailForm>().Single();
            tourDetailForm.RefreshLocation(tourLocationBIZ.GetByTourID(this.tour.ID));

        }
    }
}
