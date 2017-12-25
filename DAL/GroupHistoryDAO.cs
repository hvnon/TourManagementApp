using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System;

using DAL.Entities;

namespace DAL
{    
    public class GroupHistoryDAO
    {
        private TourContext db = new TourContext();

        public void Add(GroupHistory g)
        {
            db.GroupHistories.Add(g);
            db.SaveChanges();
        }

        public List<GroupHistory> GetByGroupIDAndDate(int groupID, 
            DateTime fromDate, DateTime toDate)
        {
            return db.GroupHistories
                .Include(s => s.Group)
                .Where(s => s.GroupID == groupID 
                    && s.Date >= fromDate
                    && s.Date <= toDate
                    )
                .OrderByDescending(s => s.Date)
                .ToList();
        }
    }
}
