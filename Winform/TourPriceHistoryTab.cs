using System;

using BIZ;
using DAL.Entities;

using System.Windows.Forms;
using System.Collections.Generic;

namespace Winform
{
    public partial class TourDetailForm : MyCustomForm
    {
        public void RefreshTourPrice(List<TourPriceHistory> tourPrices)
        {
            tourPriceTable.Columns[2].DefaultCellStyle.Format = "#,0.###";

            int i = 1;
            foreach(var t in tourPrices)
            {
                tourPriceTable.Rows.Add(
                    t.ID,
                    i,
                    t.Price,
                    t.Date
                );
                i++;
            }              
            
        }
        
    }
}
