using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using DAL.Entities;
using BIZ;

using System.Windows.Forms;
namespace Winform
{
    public partial class AddEmployeeForm : Form
    {
        EmployeeBIZ employeeBIZ = new EmployeeBIZ();

        public AddEmployeeForm()
        {
            InitializeComponent();
            maleRb.Checked = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lastNameTxt.Text == "")
                {
                    MessageBox.Show("Họ nhân viên không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lastNameTxt.Focus();
                    return;
                }
                if (firstNameTxt.Text == "")
                {
                    MessageBox.Show("Tên nhân viên không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    firstNameTxt.Focus();
                    return;
                }
                if (identityNumberTxt.Text == "")
                {
                    MessageBox.Show("Chứng minh nhân dân không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    identityNumberTxt.Focus();
                    return;
                }
                if (phoneTxt.Text == "")
                {
                    MessageBox.Show("Số điện thoại không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneTxt.Focus();
                    return;
                }
                if (addressTxt.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addressTxt.Focus();
                    return;
                }
                employeeBIZ = new EmployeeBIZ();
                Employee emp = new Employee();
                string lastName = lastNameTxt.Text.Trim();
                string firstName = firstNameTxt.Text.Trim();
                string identityNumber = identityNumberTxt.Text.Trim();
                string phone = phoneTxt.Text.Trim();
                string address = addressTxt.Text.Trim();
                DateTime DOB = DateTime.Parse(DOBPicker.Text);
                bool gender = true;
                if (maleRb.Checked == true)
                {
                    gender = true;
                }
                if (femaleRb.Checked == true)
                {
                    gender = false;
                }
                emp.FirstName = lastName;
                emp.LastName = firstName;
                emp.IdentityNumber = identityNumber;
                emp.Phone = phone;
                emp.Address = address;
                emp.BirthDate = DOB;
                emp.Gender = gender;

                employeeBIZ.Add(emp);

                MessageBox.Show("Thêm thành công");

                lastNameTxt.Text = "";
                firstNameTxt.Text = "";
                identityNumberTxt.Text = "";
                phoneTxt.Text = "";
                addressTxt.Text = "";
                maleRb.Checked = true;

                var employeeForm = Application.OpenForms.OfType<MainForm>().Single();
                employeeForm.RefreshEmployeeForm(employeeBIZ.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
