using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using DAL.Entities;
using BIZ;
using System.Windows.Forms;
using System.Linq;

namespace Winform
{
    public partial class AddGroupFeeForm : MyCustomForm
    {
        FeeTypeBIZ feeTypeBIZ = new FeeTypeBIZ();
        GroupFeeBIZ groupFeeBIZ = new GroupFeeBIZ();
        CustomerGroupBIZ customerGroupBIZ = new CustomerGroupBIZ();
        int groupID;

        public AddGroupFeeForm(int groupID)
        {
            InitializeComponent();

            this.groupID = groupID;

            feeTypeCb.DataSource = feeTypeBIZ.GetAll();
            feeTypeCb.ValueMember = "ID";
            feeTypeCb.DisplayMember = "Name";
            feeTypeCb.SelectedIndex = 0;

            priceTxt.KeyPress += CheckIsNumber;

        }

        private void addFeeBtn_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(priceTxt.Text);
            int feeType = (int)feeTypeCb.SelectedValue;
            string des = descriptionTxt.Text;

            if(price == 0)
            {
                MessageBox.Show("Giá không được trống");
                return;
            }
            if (des == "")
            {
                MessageBox.Show("Mô tả không được trống");
                return;
            }
            GroupFee g = new GroupFee()
            {
                GroupID = this.groupID,
                FeeTypeID = feeType,
                Description = des,
                Price = price
            };
            groupFeeBIZ.Add(g);

            if ((Application.OpenForms["GroupDetailForm"] as GroupDetailForm) != null)
            {
                var groupDetailForm = Application.OpenForms.OfType<GroupDetailForm>().Single();

                groupFeeBIZ = new GroupFeeBIZ();

                customerGroupBIZ = new CustomerGroupBIZ();
                var customers = customerGroupBIZ.GetByGroupID(this.groupID);
                int numberOfCustomer = customers.Count;

                groupDetailForm.RefreshFeeForm(groupFeeBIZ.GetByGroupID(this.groupID), numberOfCustomer);
            }
        }
    }
}
