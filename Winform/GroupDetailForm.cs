using System;
using System.Collections.Generic;

using DAL.Entities;
using BIZ;

namespace Winform
{
    public partial class GroupDetailForm : MyCustomForm
    {
        CustomerBIZ customerBIZ = new CustomerBIZ();
        CustomerGroupBIZ customerGroupBIZ = new CustomerGroupBIZ();

        RoleBIZ roleBIZ = new RoleBIZ();
        
        GroupFeeBIZ groupFeeBIZ = new GroupFeeBIZ();

        Group group = new Group();

        public GroupDetailForm(Group group)
        {
            InitializeComponent();

            this.group = group;

            this.Text = group.Code + " - " + group.Name;

            feeTable.Columns["Price"].DefaultCellStyle.Format = "#,0.###";
            feeTable.Columns["SubTotal"].DefaultCellStyle.Format = "#,0.###";

            var customers = customerGroupBIZ.GetByGroupID(group.ID);

            int numberOfCustomer = customers.Count;
            feeTable.Columns["SubTotal"].HeaderText = "Thành tiền (" 
                + numberOfCustomer + " khách)";

            RefreshFeeForm(groupFeeBIZ.GetByGroupID(group.ID), numberOfCustomer);
            RefreshCustomerForm(customers);

            RefreshEmployeeForm(roleBIZ.GetByGroupID(group.ID));
        }       

        public void RefreshCustomerForm(List<CustomerGroup> customerGroup)
        {
            customerTable.Rows.Clear();

            for (var i = 0; i < customerGroup.Count; i++)
            {
                string gender;
                if (customerGroup[i].Customer.Gender == true)
                    gender = "Nam";
                else gender = "Nữ";
                customerTable.Rows.Add(
                    customerGroup[i].Customer.ID,
                    customerGroup[i].Customer.Code,
                    customerGroup[i].Customer.LastName,
                    customerGroup[i].Customer.FirstName,
                    customerGroup[i].Customer.IdentityNumber,
                    customerGroup[i].Customer.Phone,
                    customerGroup[i].Customer.Address,
                    customerGroup[i].Customer.BirthDate,
                    gender
                );
            }
        }

        private void searchCustomerBtn_Click(object sender, EventArgs e)
        {
            string id = codeTxt.Text;
            string identityNumber = indentityNumberTxt.Text;
            var result = customerGroupBIZ.Find(id, identityNumber);
            RefreshCustomerForm(result);
        }

        private void refreshCustomerBtn_Click(object sender, EventArgs e)
        {
            customerGroupBIZ = new CustomerGroupBIZ();
            RefreshCustomerForm(customerGroupBIZ.GetByGroupID(this.group.ID));
        }
    }
}
