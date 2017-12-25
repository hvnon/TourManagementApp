using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

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
    }
}
