using System;
using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class EditTourForm : MyCustomForm
    {
        TourBIZ tourBIZ = new TourBIZ();
        TourTypeBIZ tourTypeBIZ = new TourTypeBIZ();
        CityBIZ cityBIZ = new CityBIZ();
        DistrictBIZ districtBIZ = new DistrictBIZ();

        int tourID = 0;

        public EditTourForm(int tourID)
        {
            InitializeComponent();

            this.tourID = tourID;

            Tour tour = tourBIZ.GetByID(tourID);

            codeTxt.Text = tour.Code;

            nameTxt.Text = tour.Name;

            // load all tour types to combobox
            var tourTypes = tourTypeBIZ.GetAll();

            tourTypes.Insert(0, new TourType() { ID = -1, Name = "------ Chọn loại tour -----" });

            tourTypeCb.DataSource = tourTypes;
            tourTypeCb.ValueMember = "ID";
            tourTypeCb.DisplayMember = "Name";
            tourTypeCb.SelectedValue = tour.TourTypeID;

            dayTxt.KeyPress += CheckIsNumber;
            nightTxt.KeyPress += CheckIsNumber;
            priceTxt.KeyPress += CheckIsNumber;
            dayTxt.Text = tour.Day.ToString();
            nightTxt.Text = tour.Night.ToString();
            priceTxt.Text = tour.Price.ToString();

            // load all cities
            var cities = cityBIZ.GetAll();

            cities.Insert(0, new City() { ID = -1, Name = "-------- Tỉnh/thành -------" });

            cityCb.DataSource = cities;
            cityCb.ValueMember = "ID";
            cityCb.DisplayMember = "Name";
            cityCb.SelectedValue = tour.City.ID;

            // load all districts
            var districts = districtBIZ.GetByCityID(tour.City.ID);
            districts.Insert(0, new District() { ID = -1, Name = "-------- Quận/huyện -------" });
            districtCb.DataSource = districts;
            districtCb.ValueMember = "ID";
            districtCb.DisplayMember = "Name";
            districtCb.SelectedValue = tour.District.ID;

            // load status
            statusCb.Items.Add("Đang bán");
            statusCb.Items.Add("Hết bán");
            if(tour.Status == "Đang bán")
             statusCb.SelectedIndex = 0;
            else statusCb.SelectedIndex = 1;

            descriptionTxt.Text = tour.Description;
        }

        private void cityCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cityCb.SelectedIndex != -1)
            {
                var districts = districtBIZ.GetByCityID((int)cityCb.SelectedValue);
                districts.Insert(0, new District() { ID = -1, Name = "-------- Quận/huyện -------" });
                districtCb.DataSource = districts;
                districtCb.ValueMember = "ID";
                districtCb.DisplayMember = "Name";
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string code = codeTxt.Text;
            int tourTypeID = (int)tourTypeCb.SelectedValue;
            int cityID = (int)cityCb.SelectedValue;
            int districtID = (int)districtCb.SelectedValue;
            int d, n, day = 0, night = 0, p, price = 0;
            if (Int32.TryParse(dayTxt.Text, out d))
                day = d;
            if (Int32.TryParse(nightTxt.Text, out n))
                night = n;
            if (Int32.TryParse(priceTxt.Text, out p))
                price = p;
            string status = statusCb.Items[statusCb.SelectedIndex].ToString();
            string description = descriptionTxt.Text;

            if (name == "")
            {
                MessageBox.Show("Tên tour không được trống!");
                return;
            }
            if (tourTypeID == 0)
            {
                MessageBox.Show("Loại tour không được trống!");
                return;
            }
            if (cityID == 0)
            {
                MessageBox.Show("Tỉnh/thành không được trống!");
                return;
            }
            if (districtID == 0)
            {
                MessageBox.Show("Quận/huyện không được trống!");
                return;
            }
            if (price == 0)
            {
                MessageBox.Show("Giá không được trống!");
                return;
            }

            Tour tour = new Tour()
            {
                ID = this.tourID,
                Code = code,
                Name = name,
                TourTypeID = tourTypeID,
                FromCity = cityID,
                FromDistrict = districtID,
                Day = day,
                Night = night,
                Price = price,
                Status = status,
                Description = description
            };

            tourBIZ.Update(tour);

            this.Close();

            var tourForm = Application.OpenForms.OfType<MainForm>().Single();
            tourForm.RefreshTourForm(tourBIZ.GetAll());
        }

 
    }
}
