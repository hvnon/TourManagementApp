using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using DAL.Entities;
using BIZ;

namespace Winform
{
    public partial class AddEmployeeToGroupForm : Form
    {
        EmployeeBIZ employeeBIZ = new EmployeeBIZ();
        RoleBIZ roleBIZ = new RoleBIZ();

        int groupID;

        public AddEmployeeToGroupForm(int groupID)
        {
            InitializeComponent();

            this.groupID = groupID;

            RefreshEmployeeForm(employeeBIZ.GetAll());
        }

        public void RefreshEmployeeForm(List<Employee> employee)
        {
            string gender;
            employeeTable.Rows.Clear();

            for (var i = 0; i < employee.Count; i++)
            {
                if (employee[i].Gender == true)
                {
                    gender = "Nam";
                }
                else
                {
                    gender = "Nữ";
                }

                employeeTable.Rows.Add(
                    employee[i].ID,
                    employee[i].FirstName,
                    employee[i].LastName,
                    employee[i].IdentityNumber,
                    employee[i].Phone,
                    employee[i].Address,
                    employee[i].BirthDate,
                    gender
                );
            }
        }

        private void addRoleBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == "")
            {
                MessageBox.Show("Vai trò không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowIndex = employeeTable.CurrentCell.RowIndex;
            if(rowIndex >=0)
            {
                int employeeID = (int)employeeTable.Rows[rowIndex].Cells[0].Value;
                roleBIZ.Add(new Role() { EmployeeID = employeeID, GroupID = this.groupID, RoleName = roleTxt.Text});
                if ((Application.OpenForms["GroupDetailForm"] as GroupDetailForm) != null)
                {
                    var groupDetailForm = Application.OpenForms.OfType<GroupDetailForm>().Single();
                    groupDetailForm.RefreshEmployeeForm(roleBIZ.GetByGroupID(this.groupID));
                }
                roleTxt.Text = "";
            }
        }
    }
}
