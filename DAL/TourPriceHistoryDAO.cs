using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using DAL.Entities;

namespace DAL
{    
    public class TourPriceHistoryDAO
    {
        private TourContext db = new TourContext();

        public List<TourPriceHistory> GetByTourID(int tourID)
        {
            return db.TourPriceHistories.Where(s => s.TourID == tourID)
                .ToList();
        }

        public TourPriceHistory GetLatestPriceOfTour(int tourID)
        {
            return db.TourPriceHistories.Where(s => s.TourID == tourID)
                .OrderByDescending(s => s.Date).FirstOrDefault();
        }

        public void Add(TourPriceHistory t)
        {
            db.TourPriceHistories.Add(t);
            db.SaveChanges();
        }
    }
}
