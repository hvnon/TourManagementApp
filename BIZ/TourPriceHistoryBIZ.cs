using System.Collections.Generic;
using System.Linq;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class TourPriceHistoryBIZ
    {
        TourPriceHistoryDAO tourPriceHistoryDAO = new TourPriceHistoryDAO();

        public List<TourPriceHistory> GetByTourID(int tourID)
        {
            return tourPriceHistoryDAO.GetByTourID(tourID);
        }


    }
}
