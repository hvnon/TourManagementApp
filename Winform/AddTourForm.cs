using System;
using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class AddTourForm : MyCustomForm
    {
        TourBIZ tourBIZ = new TourBIZ();
        TourTypeBIZ tourTypeBIZ = new TourTypeBIZ();
        CityBIZ cityBIZ = new CityBIZ();
        DistrictBIZ districtBIZ = new DistrictBIZ();

        public AddTourForm()
        {
            InitializeComponent();
            //generate tour code
            codeTxt.Text = tourBIZ.GenerateCode();

            // placeholders
            dayTxt.ForeColor = System.Drawing.Color.Gray;
            nightTxt.ForeColor = System.Drawing.Color.Gray;

            dayTxt.KeyPress += CheckIsNumber;
            nightTxt.KeyPress += CheckIsNumber;
            priceTxt.KeyPress += CheckIsNumber;

            dayTxt.GotFocus += RemoveText;
            nightTxt.GotFocus += RemoveText;

            dayTxt.LostFocus += AddText;
            nightTxt.LostFocus += AddText;

            // load all tour types to combobox
            var tourTypes = tourTypeBIZ.GetAll();

            tourTypes.Insert(0, new TourType() { ID = -1, Name = "------ Chọn loại tour -----" });

            tourTypeCb.DataSource = tourTypes;
            tourTypeCb.ValueMember = "ID";
            tourTypeCb.DisplayMember = "Name";

            // load all cities
            var cities = cityBIZ.GetAll();

            cities.Insert(0, new City() { ID = -1, Name = "-------- Tỉnh/thành -------" });

            cityCb.DataSource = cities;
            cityCb.ValueMember = "ID";
            cityCb.DisplayMember = "Name";

            districtCb.Items.Add("-------- Quận/huyện -------");
            districtCb.SelectedIndex = 0;

            // load status
            statusCb.Items.Add("Đang bán");
            statusCb.Items.Add("Hết bán");
            statusCb.SelectedIndex = 0;
        }

        private void cityCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cityCb.SelectedIndex != -1)
            {
                var districts = districtBIZ.GetByCityID((int)cityCb.SelectedValue);
                districtCb.Items.Clear();
                districts.Insert(0, new District() { ID = -1, Name = "-------- Quận/huyện -------" });
                districtCb.DataSource = districts;
                districtCb.ValueMember = "ID";
                districtCb.DisplayMember = "Name";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string code = codeTxt.Text;
            int tourTypeID = (int)tourTypeCb.SelectedValue;
            int cityID = (int)cityCb.SelectedValue;
            int districtID = (int)districtCb.SelectedIndex;
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
            if (day == 0)
            {
                MessageBox.Show("Số ngày không được trống!");
                return;
            }
            if (night == 0)
            {
                MessageBox.Show("Số đêm không được trống!");
                return;
            }
            if (price == 0)
            {
                MessageBox.Show("Giá không được trống!");
                return;
            }

            Tour tour = new Tour()
            {
                Name = name,
                Code = code,
                TourTypeID = tourTypeID,
                FromCity = cityID,
                FromDistrict = districtID,
                Day = day,
                Night = night,
                Price = price,
                Status = status,
                Description = description
            };

            tourBIZ.Add(tour) ;

            MessageBox.Show("Tạo tour mới thành công.");

            ResetForm();

            var tourForm = Application.OpenForms.OfType<MainForm>().Single();
            tourForm.RefreshTourForm(tourBIZ.GetAll());
        }

        private void ResetForm()
        {
            codeTxt.Text = tourBIZ.GenerateCode();
            nameTxt.Text = "";
            statusCb.SelectedIndex = 0;
            priceTxt.Text = "";
            dayTxt.Text = "ngày";
            nightTxt.Text = "đêm";
            tourTypeCb.SelectedIndex = 0;
            cityCb.SelectedIndex = 0;
            descriptionTxt.Text = "";
            dayTxt.ForeColor = System.Drawing.Color.Gray;
            nightTxt.ForeColor = System.Drawing.Color.Gray;
        }

        // placeholders
        private void RemoveText(object sender, EventArgs e)
        {
            int i;
            switch (((TextBox)sender).Name)
            {
                case "dayTxt":
                    if (!int.TryParse(dayTxt.Text, out i))
                    {
                        dayTxt.Text = "";
                        dayTxt.ForeColor = System.Drawing.Color.Black;
                    }
                    break;
                case "nightTxt":
                    if (!int.TryParse(nightTxt.Text, out i))
                    {
                        nightTxt.Text = "";
                        nightTxt.ForeColor = System.Drawing.Color.Black;
                    }
                    break;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "dayTxt":
                    if (dayTxt.Text == "")
                    {
                        dayTxt.Text = "ngày";
                        dayTxt.ForeColor = System.Drawing.Color.Gray;
                    }
                    break;
                case "nightTxt":
                    if (nightTxt.Text == "")
                    {
                        nightTxt.Text = "đêm";
                        nightTxt.ForeColor = System.Drawing.Color.Gray;
                    }
                    break;
            }
        }

        
    }
}
