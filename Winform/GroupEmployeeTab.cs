using System;

using BIZ;
using DAL.Entities;

using System.Collections.Generic;

namespace Winform
{
    public partial class GroupDetailForm : MyCustomForm
    {
        public void RefreshEmployeeForm(List<Role> employeeGroup)
        {
            string gender;
            employeeTable.Rows.Clear();

            for (var i = 0; i < employeeGroup.Count; i++)
            {
                if (employeeGroup[i].Employee.Gender == true)
                {
                    gender = "Nam";
                }
                else
                {
                    gender = "Nữ";
                }

                employeeTable.Rows.Add(
                    employeeGroup[i].ID,
                    employeeGroup[i].Employee.LastName,
                    employeeGroup[i].Employee.FirstName,
                    employeeGroup[i].Employee.IdentityNumber,
                    employeeGroup[i].Employee.Phone,
                    employeeGroup[i].Employee.Address,
                    employeeGroup[i].Employee.BirthDate,
                    gender,
                    employeeGroup[i].RoleName
                );
            }
        }

        private void findroleBtn_Click(object sender, EventArgs e)
        {
            string role = roleTxt.Text;
            roleBIZ = new RoleBIZ();
            List<Role> result = roleBIZ.Find(role, group.ID);
            RefreshEmployeeForm(result);
        }

        private void refreshEmployeeBtn_Click(object sender, EventArgs e)
        {
            roleBIZ = new RoleBIZ();
            RefreshEmployeeForm(roleBIZ.GetByGroupID(group.ID));
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeToGroupForm frm = new AddEmployeeToGroupForm(group.ID);
            frm.ShowDialog();
            RefreshEmployeeForm(roleBIZ.GetByGroupID(group.ID));
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            roleBIZ = new RoleBIZ();
            int ID = (int)employeeTable.Rows[employeeTable.CurrentRow.Index].Cells[0].Value;
            roleBIZ.Delete(ID);
            RefreshEmployeeForm(roleBIZ.GetByGroupID(group.ID));
        }
    }
}
