using System;
using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class AddGroupForm : MyCustomForm
    {
        GroupBIZ groupBIZ = new GroupBIZ();
        TourBIZ tourBIZ = new TourBIZ();
        Tour tour;

        public AddGroupForm(Tour tour)
        {
            InitializeComponent();

            tourCb.DataSource = tourBIZ.GetAll();
            tourCb.ValueMember = "ID";
            tourCb.DisplayMember = "Code";
            tourCb.SelectedIndex = 0;

            if (tour != null)
            {
                tourCb.SelectedIndex = tour.ID - 1;
                tourCb.Enabled = false;

                this.tour = tour;
                this.Text = "Thêm đoàn cho tour " + tour.Code + " - " + tour.Name;
            }                    

            //generate group code
            codeTxt.Text = groupBIZ.GenerateCode();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int tourID;
            string name = nameTxt.Text;
            string code = codeTxt.Text;
            DateTime startDate = Convert.ToDateTime(startDatePicker.Value.ToString());
            DateTime endDate = Convert.ToDateTime(endDatePicker.Value.ToString());
            string pickupLocation = pickupLocationTxt.Text;
            string dropLocation = dropLocationTxt.Text;
            string description = descriptionTxt.Text;
            string policy = policyTxt.Text;

            if (name == "")
            {
                MessageBox.Show("Tên đoàn không được trống!");
                return;
            }
            if (pickupLocation == "")
            {
                MessageBox.Show("Địa điểm rước không được trống!");
                return;
            }
            if (dropLocation == "")
            {
                MessageBox.Show("Địa điểm thả không được trống!");
                return;
            }
            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày về phải sau ngày đi!");
                return;
            }
            if (this.tour == null)
                tourID = (int)tourCb.SelectedValue;
            else
                tourID = this.tour.ID;

            Group group = new Group()
            {
                Code = code,
                TourID = tourID,
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                PickupLocation = pickupLocation,
                DropLocation = dropLocation,
                Description = description,
                Policy = policy
            };
   
            groupBIZ.Add(group) ;

            MessageBox.Show("Tạo đoàn mới thành công.");

            ResetForm();

            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.RefreshGroupForm(groupBIZ.GetAll());
            if ((Application.OpenForms["TourDetailForm"] as TourDetailForm) != null)
            {
                var tourDetailForm = Application.OpenForms.OfType<TourDetailForm>().Single();
                tourDetailForm.RefreshGroup(groupBIZ.GetByTourID(tourID));
            }
        }

        private void ResetForm()
        {
            codeTxt.Text = groupBIZ.GenerateCode();
            nameTxt.Text = "";
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
            pickupLocationTxt.Text = "";
            dropLocationTxt.Text = "";
            descriptionTxt.Text = "";
            policyTxt.Text = "";
        }

        
    }
}
