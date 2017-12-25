using System;
using System.Linq;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Winform
{
    public partial class MainForm : MyCustomForm
    {
        EmployeeBIZ employeeBIZ = new EmployeeBIZ();

        public void RefreshEmployeeForm(List<Employee> employeeBIZ)
        {
            string gender;
            employeeTable.Rows.Clear();

            for (var i = 0; i < employeeBIZ.Count; i++)
            {
                if (employeeBIZ[i].Gender == true)
                {
                    gender = "Nam";
                }
                else
                {
                    gender = "Nữ";
                }

                employeeTable.Rows.Add(
                    employeeBIZ[i].ID,
                    employeeBIZ[i].FirstName,
                    employeeBIZ[i].LastName,
                    employeeBIZ[i].IdentityNumber,
                    employeeBIZ[i].Phone,
                    employeeBIZ[i].Address,
                    employeeBIZ[i].BirthDate,
                    gender
                );
            }
        }
        private void searchEmployeeBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeFirstNameTxt.Text = "";
            employeeLastNameTxt.Text = "";
            employeeIdentityNumberTxt.Text = "";

            employeeBIZ = new EmployeeBIZ();
            RefreshEmployeeForm(employeeBIZ.GetAll());
        }

        private void refreshEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeBIZ = new EmployeeBIZ();
            RefreshEmployeeForm(employeeBIZ.GetAll());
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddEmployeeForm"] as AddEmployeeForm) == null)
            {
                AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
                addEmployeeForm.Show();
            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
