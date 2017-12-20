using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

using DAL.Entities;

namespace DAL
{
    public class GroupFeeDAO
    {
        private TourContext db = new TourContext();

        public List<GroupFee> GetByGroupID(int groupID)
        {
            return db.GroupFees
                    .Include(s => s.FeeType)
                    .Where(s => s.GroupID == groupID)                  
                    .OrderBy(s => s.FeeTypeID)
                    .ToList();
        }

        public void Add(GroupFee groupFee)
        {
            db.GroupFees.Add(groupFee);
            db.SaveChanges();
        }

        public void Update(GroupFee groupFee)
        {
            GroupFee g = db.GroupFees.Find(groupFee.ID);
            g.Price = groupFee.Price;
            g.Description = groupFee.Description;
            g.FeeTypeID = groupFee.FeeTypeID;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.GroupFees.Remove(db.GroupFees.Find(id));
            db.SaveChanges();
        }

        public List<GroupFee> SortByFeeType()
        {
            return db.GroupFees.GroupBy(s => s.FeeTypeID)
                           .Select(f => new GroupFee
                           {
                               Description = f.First().FeeType.Name,
                               Price = f.Sum(c => c.Price),
                           }
                            )
                            .ToList();
        }

    }
}
