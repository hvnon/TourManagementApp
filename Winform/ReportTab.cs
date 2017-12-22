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
        CustomerGroupBIZ customerGroupBIZ = new CustomerGroupBIZ();
        GroupFeeBIZ gFeeBIZ = new GroupFeeBIZ();
        GroupBIZ gBIZ = new GroupBIZ();
        TourBIZ tBIZ = new TourBIZ();

        public void InitializeReportForm()
        {
            reportTable.Columns["ReportPrice"].DefaultCellStyle.Format = "#,0.###";
            reportTable.Columns["ReportTotal"].DefaultCellStyle.Format = "#,0.###";
            reportTable.Columns["Revenue"].DefaultCellStyle.Format = "#,0.###";
        }

        private void refreshReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            reportTable.Rows.Clear();

            DateTime fromDate = reportFromDatePicker.Value;
            DateTime toDate = reportToDatePicker.Value;

            TimeSpan time1 = new TimeSpan(00, 00, 00);
            fromDate = fromDate.Date + time1;
            TimeSpan time2 = new TimeSpan(23, 59, 59);
            toDate = toDate.Date + time2;

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày không hợp lệ!");
                return;
            }

            var groups = gBIZ.GetByDate(fromDate, toDate);
            var tours = new List<Tour>();
            
            foreach (var g in groups)
            {
                var tour = tBIZ.GetByID(g.TourID);
                if (tours.SingleOrDefault(s => s == tour) == null)
                    tours.Add(tour);
            }
            foreach(var t in tours)
            {               
                reportTable.Rows.Add(
                    t.Code,
                    t.Name,
                    "",
                    "",
                    t.Price,
                    0,
                    0
                 );
                reportTable.Rows[reportTable.RowCount - 1].DefaultCellStyle.BackColor = Color.LightGray;

                int i = 0;
                int totalFee = 0;
                int totalNumberOfCustomer = 0;

                foreach (var g in groups)
                {                  
                    if (g.TourID == t.ID)
                    {                        
                        int costForOneCustomer = 0;
                        costForOneCustomer += gFeeBIZ.CountTotalFeeOfGroup(g.ID);

                        int numberOfCustomer = customerGroupBIZ.GetByGroupID(g.ID).Count;
                        totalNumberOfCustomer += numberOfCustomer;

                        int totalCostOfGroup = costForOneCustomer * numberOfCustomer;

                        reportTable.Rows.Add(
                            g.Code,
                            g.Name,
                            g.StartDate,
                            g.EndDate,
                            costForOneCustomer,
                            totalCostOfGroup,
                            0
                        );
                        totalFee += totalCostOfGroup;

                        i++;
                        
                    }                  
                }
                reportTable.Rows[reportTable.Rows.Count - i - 1].Cells[5].Value
                        = t.Price * totalNumberOfCustomer;
                reportTable.Rows[reportTable.Rows.Count - i - 1].Cells[6].Value
                = (t.Price * totalNumberOfCustomer) - totalFee;
            }
        }


    }
}
