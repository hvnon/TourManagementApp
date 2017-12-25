using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using DAL.Entities;
using BIZ;

using System.Windows.Forms;

namespace Winform
{
    public partial class AddEmployeeToGroupForm : Form
    {
        EmployeeBIZ employeeBIZ = new EmployeeBIZ();
        RoleBIZ roleBIZ = new RoleBIZ();

        public AddEmployeeToGroupForm(int IDGroup)
        {
            InitializeComponent();
            txtmanhom.Text = IDGroup.ToString();
            
        }

        private void OKClick(object sender, EventArgs e)
        {
            roleBIZ = new RoleBIZ();
            Role ro = new Role();
            if(txtVaiTro.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVaiTro.Focus();
                return;
            }
            int maNV = int.Parse(txtMaNV.Text);
            string vaiTro = txtVaiTro.Text;
            ro.EmployeeID = maNV;
            ro.GroupID = int.Parse(txtmanhom.Text);
            ro.RoleName = vaiTro;
            roleBIZ.Add(ro);
            Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            txtMaNV.Hide();
            txtmanhom.Hide();
            employeeBIZ = new EmployeeBIZ();
            refreshEmployeeForm(employeeBIZ.GetAll());
            int dongHienTai = dtgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dtgvNhanVien[0, dongHienTai].Value.ToString();
        }
        public void refreshEmployeeForm(List<Employee> employeeGroup)
        {
            string gioiTinh;
            dtgvNhanVien.Rows.Clear();

            for (var i = 0; i < employeeGroup.Count; i++)
            {
                if(employeeGroup[i].Gender == true)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                dtgvNhanVien.Rows.Add(
                    employeeGroup[i].ID,
                    employeeGroup[i].LastName,
                    employeeGroup[i].FirstName,
                    employeeGroup[i].IdentityNumber,
                    employeeGroup[i].Phone,
                    employeeGroup[i].Address,
                    employeeGroup[i].BirthDate,
                    gioiTinh
                );
            }
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongHienTai = dtgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dtgvNhanVien[0, dongHienTai].Value.ToString();
        }
        
    }
}
