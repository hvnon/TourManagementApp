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
                    employee[i].LastName,
                    employee[i].FirstName,
                    employee[i].IdentityNumber,
                    employee[i].Phone,
                    employee[i].Address,
                    employee[i].BirthDate,
                    gender,
                    "Đoàn đã đi"
                );
            }
        }
        private void searchEmployeeBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (employeeCodeTxt.Text == "")
                id = 0;
            else
                id = Convert.ToInt32(employeeCodeTxt.Text);
            string lastName = employeeLastNameTxt.Text;
            string firstName = employeeFirstNameTxt.Text;
            string identityNumber = employeeIdentityNumberTxt.Text;
            var result = employeeBIZ.Find(id, identityNumber, lastName, firstName);
            RefreshEmployeeForm(result);
        }

        private void resetEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeFirstNameTxt.Text = "";
            employeeLastNameTxt.Text = "";
            employeeIdentityNumberTxt.Text = "";
            employeeCodeTxt.Text = "";

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
            if ((Application.OpenForms["EditEmployeeForm"] as EditEmployeeForm) == null)
            {
                int employeeID = (int)
                    employeeTable.Rows[employeeTable.CurrentCell.RowIndex].Cells[0].Value;
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employeeID);
                editEmployeeForm.Show();
            }
        }
        private void employeeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["EditEmployeeForm"] as EditEmployeeForm) == null)
            {
                int employeeID = (int)
                    employeeTable.Rows[e.RowIndex].Cells[0].Value;
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employeeID);
                editEmployeeForm.Show();
            }
        }

        private void employeeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Application.OpenForms["EmployeeReportForm"] as EmployeeReportForm) == null)
            {
                if (e.ColumnIndex == 8 && e.RowIndex >= 0)
                {
                    int employeeID = Convert.ToInt32(tourTable.Rows[e.RowIndex]
                        .Cells[0].Value.ToString());
                    EmployeeReportForm employeeReportForm = new EmployeeReportForm(employeeID);
                    employeeReportForm.Show();

                }
            }
        }
    }
}
