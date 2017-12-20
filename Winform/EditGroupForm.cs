using System;
using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class EditGroupForm : MyCustomForm
    {
        GroupBIZ groupBIZ = new GroupBIZ();
        Group oldGroup;

        public EditGroupForm(int groupID)
        {
            InitializeComponent();

            this.oldGroup = groupBIZ.GetByID(groupID);

            nameTxt.Text = oldGroup.Name;
            codeTxt.Text = oldGroup.Code;
            startDatePicker.Value = oldGroup.StartDate;
            endDatePicker.Value = oldGroup.EndDate;
            pickupLocationTxt.Text = oldGroup.PickupLocation;
            dropLocationTxt.Text = oldGroup.DropLocation;
            descriptionTxt.Text = oldGroup.Description;
            policyTxt.Text = oldGroup.Policy;

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
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

            Group newGroup = new Group()
            {
                ID = this.oldGroup.ID,
                Code = code,
                TourID = oldGroup.TourID,
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                PickupLocation = pickupLocation,
                DropLocation = dropLocation,
                Description = description,
                Policy = policy
            };
   
            groupBIZ.Update(newGroup) ;

            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.RefreshGroupForm(groupBIZ.GetAll());
            if ((Application.OpenForms["TourDetailForm"] as TourDetailForm) != null)
            {
                var tourDetailForm = Application.OpenForms.OfType<TourDetailForm>().Single();
                tourDetailForm.RefreshGroup(groupBIZ.GetByTourID(oldGroup.TourID));
            }

            this.Close();
        }
    }
}
