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
        TourPriceHistoryBIZ tourHistoryBIZ = new TourPriceHistoryBIZ();
        GroupHistoryBIZ groupHistoryBIZ = new GroupHistoryBIZ();

        public void InitializeReportForm()
        {
            reportTable.Columns["ReportPrice"].DefaultCellStyle.Format = "#,0.###";
            reportTable.Columns["ReportTotal"].DefaultCellStyle.Format = "#,0.###";
            reportTable.Columns["Revenue"].DefaultCellStyle.Format = "#,0.###";
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

            var groupHistoryResult = new List<GroupHistory>();
            var tourHistoryResult = new List<TourPriceHistory>();

            foreach (var g in groups)
            {
                var groupHistories =
                    groupHistoryBIZ.GetByGroupIDAndDate(g.ID, fromDate, toDate);
                foreach(var s in groupHistories)
                    groupHistoryResult.Add(s);

                var tourHistory = tourHistoryBIZ.GetByTourID(g.TourID);
                foreach (var t in tourHistory)
                    if (tourHistoryResult
                        .SingleOrDefault(s => s == t) == null)
                        tourHistoryResult.Add(t);
            }

            foreach(var t in tourHistoryResult)
            {
                reportTable.Rows.Add(
                    t.Tour.Code,
                    t.Tour.Name,
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

                foreach (var g in groupHistoryResult)
                {
                    if (g.Group.TourID == t.TourID && g.Date == t.Date)
                    {                      
                        int costForOneCustomer = 0;
                        costForOneCustomer += gFeeBIZ.CountTotalFeeOfGroup(g.GroupID);

                        int numberOfCustomer = customerGroupBIZ.GetByGroupID(g.GroupID).Count;
                        totalNumberOfCustomer += numberOfCustomer;

                        int totalCostOfGroup = costForOneCustomer * numberOfCustomer;

                        reportTable.Rows.Add(
                            g.Group.Code,
                            g.Group.Name,
                            g.Group.StartDate,
                            g.Group.EndDate,
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
