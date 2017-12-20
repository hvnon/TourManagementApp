using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;

namespace Winform
{
    public partial class MainForm : MyCustomForm
    {
        TourBIZ tourBIZ = new TourBIZ();
        TourTypeBIZ tourTypeBIZ = new TourTypeBIZ();
        CityBIZ cityBIZ = new CityBIZ();
        DistrictBIZ districtBIZ = new DistrictBIZ();

        public MainForm()
        {
            InitializeComponent();

            InitializeTourForm();
            RefreshTourForm(tourBIZ.GetAll());

            InitializeGroupForm();
            RefreshGroupForm(groupBIZ.GetAll());
            searchGroupBtn.Click += searchGroupBtn_Click;
            resetGroupBtn.Click += resetGroupBtn_Click;
            refreshGroupBtn.Click += refreshGroupBtn_Click;
            addGroupBtn.Click += addGroupBtn_Click;
            groupTable.CellMouseMove += groupTable_CellMouseMove;
            groupTable.CellDoubleClick += groupTable_CellDoubleClick;
            groupTable.CellClick += viewGroupDetails;

        }

        public void InitializeTourForm()
        {
            // placeholders
            dayTxt.ForeColor = System.Drawing.Color.Gray;
            nightTxt.ForeColor = System.Drawing.Color.Gray;
            priceFromTxt.ForeColor = System.Drawing.Color.Gray;
            priceToTxt.ForeColor = System.Drawing.Color.Gray;

            dayTxt.KeyPress += CheckIsNumber;
            nightTxt.KeyPress += CheckIsNumber;
            priceFromTxt.KeyPress += CheckIsNumber;
            priceToTxt.KeyPress += CheckIsNumber;

            dayTxt.GotFocus += RemoveText;
            nightTxt.GotFocus += RemoveText;
            priceFromTxt.GotFocus += RemoveText;
            priceToTxt.GotFocus += RemoveText;

            dayTxt.LostFocus += AddText;
            nightTxt.LostFocus += AddText;
            priceFromTxt.LostFocus += AddText;
            priceToTxt.LostFocus += AddText;

            // load all tour types to combobox
            var tourTypes = tourTypeBIZ.GetAll();

            tourTypes.Insert(0, new TourType() { ID = -1, Name = "------ Chọn loại tour -----" });

            tourTypeCb.DataSource = tourTypes;
            tourTypeCb.ValueMember = "ID";
            tourTypeCb.DisplayMember = "Name";

            // load all cities
            var cities = cityBIZ.GetAll();

            cities.Insert(0, new City() { ID = -1, Name = "------------ Tỉnh/thành ------------" });

            cityCb.DataSource = cities;
            cityCb.ValueMember = "ID";
            cityCb.DisplayMember = "Name";

            // load status
            statusCb.Items.Clear();
            statusCb.Items.Add("Đang bán");
            statusCb.Items.Add("Hết bán");
            statusCb.SelectedIndex = 0;

            // load tours
            tourTable.Columns["TourPrice"].DefaultCellStyle.Format = "#,0.###";
            tourTable.Columns[10].Width = 50;
        }

        public void RefreshTourForm(List<Tour> tours)
        {
            tourTable.Rows.Clear();

            foreach (var t in tours)
            {
                tourTable.Rows.Add(
                    t.ID,
                    t.Code,
                    t.Name,
                    t.TourType.Name,
                    t.City.Name + "-" + t.District.Name,
                    t.Day,
                    t.Night,
                    t.Price,
                    t.Status,
                    t.Description,
                    "Chi tiết"
                );
            }
        }

        private void cityCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityCb.SelectedIndex != -1)
            {
                var districts = districtBIZ.GetByCityID(cityCb.SelectedIndex);
                districts.Insert(0, new District() { ID = -1,
                    Name = "--------------- Quận/huyện ---------------"
                });
                districtCb.DataSource = districts;
                districtCb.ValueMember = "ID";
                districtCb.DisplayMember = "Name";
            }
        }

        private void refreshTourBtn_Click(object sender, EventArgs e)
        {
            tourBIZ = new TourBIZ();
            RefreshTourForm(tourBIZ.GetAll());
        }

        private void searchTourBtn_Click(object sender, EventArgs e)
        {
            string code = tourCodeTxt.Text;
            string name = tourNameTxt.Text;
            int tourTypeID = tourTypeCb.SelectedIndex;
            int cityID = cityCb.SelectedIndex;
            int districtID = districtCb.SelectedIndex;

            int d, n, day = 0, night = 0, min, max, minPrice = 0, maxPrice = 0;
            if (Int32.TryParse(dayTxt.Text, out d))
                day = d;
            if (Int32.TryParse(nightTxt.Text, out n))
                night = n;
            if (Int32.TryParse(priceFromTxt.Text, out min))
                minPrice = min;
            if (Int32.TryParse(priceToTxt.Text, out max))
                maxPrice = max;

            string status = statusCb.DisplayMember;

            var result = tourBIZ.Find(code, name, tourTypeID, cityID, districtID, day, night, status, minPrice, maxPrice);

            RefreshTourForm(result);
        }

        private void resetTourBtn_Click(object sender, EventArgs e)
        {
            InitializeTourForm();

            tourCodeTxt.Text = "";
            tourNameTxt.Text = "";
            dayTxt.Text = "ngày";
            nightTxt.Text = "đêm";
            priceFromTxt.Text = "giá từ";
            priceToTxt.Text = "giá đến";

            RefreshTourForm(tourBIZ.GetAll());
        }

        private void createTourBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddTourForm"] as AddTourForm) == null)
            {
                AddTourForm addTourForm = new AddTourForm();
                addTourForm.Show();
            }
        }

        private void tourTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["EditTourForm"] as EditTourForm) == null)
            {
                if (e.ColumnIndex != 10 && e.RowIndex >= 0)
                {
                    int tourID = Convert.ToInt32(
                    tourTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                    EditTourForm editTourForm = new EditTourForm(tourID);
                    editTourForm.Show();
                }
            }
        }

        // edit tour by clicking pencil icon
        private void editTourBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["EditTourForm"] as EditTourForm) == null)
            {
                int rowIndex = tourTable.CurrentCell.RowIndex;

                if (rowIndex >= 0)
                {
                    int tourID = Convert.ToInt32(
                     tourTable.Rows[rowIndex].Cells[0].Value.ToString());
                    EditTourForm editTourForm = new EditTourForm(tourID);
                    editTourForm.Show();
                }                 
            }
        }

        private void viewTourDetail(object sender, DataGridViewCellEventArgs e)
        {
           if ((Application.OpenForms["TourDetailForm"] as TourDetailForm) == null)
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0)
                {
                    int tourID = Convert.ToInt32(tourTable.Rows[e.RowIndex]
                        .Cells[0].Value.ToString());
                    TourDetailForm tourDetailForm = new TourDetailForm(tourBIZ.GetByID(tourID));
                    tourDetailForm.Show();

                }
            }
            
        }

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
                case "priceFromTxt":
                    if (!int.TryParse(priceFromTxt.Text, out i))
                    {
                        priceFromTxt.Text = "";
                        priceFromTxt.ForeColor = System.Drawing.Color.Black;
                    }
                    break;
                case "priceToTxt":
                    if (!int.TryParse(priceToTxt.Text, out i))
                    {
                        priceToTxt.Text = "";
                        priceToTxt.ForeColor = System.Drawing.Color.Black;
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
                case "priceFromTxt":
                    if (priceFromTxt.Text == "")
                    {
                        priceFromTxt.Text = "giá từ";
                        priceFromTxt.ForeColor = System.Drawing.Color.Gray;
                    }
                    break;
                case "priceToTxt":
                    if (priceToTxt.Text == "")
                    {
                        priceToTxt.Text = "giá đến";
                        priceToTxt.ForeColor = System.Drawing.Color.Gray;
                    }
                    break;
            }
        }

        private void tourTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 10)
                tourTable.Cursor = Cursors.Hand;
            else
                tourTable.Cursor = Cursors.Default;
        }

        
    }
}
