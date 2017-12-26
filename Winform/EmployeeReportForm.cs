using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Winform
{
    public partial class EmployeeReportForm : Form
    {
        RoleBIZ roleBIZ = new RoleBIZ();

        public EmployeeReportForm(int employeeID)
        {
            InitializeComponent();
            Refresh(roleBIZ.EmployeeReport(employeeID));
        }

        public void Refresh(List<Role> roles)
        {
            employeeReportTable.Rows.Clear();

            foreach (var t in roles)
            {
                employeeReportTable.Rows.Add(
                    t.Group.Code,
                    t.Group.Tour.Code,
                    t.Group.Name,
                    t.Group.StartDate,
                    t.Group.EndDate,
                    t.Group.PickupLocation,
                    t.Group.DropLocation,
                    t.Group.Description,
                    t.Group.Policy                    
                );                
            }
        }
    }
}
