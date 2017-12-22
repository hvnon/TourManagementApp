using System;
using System.Linq;
using System.Collections.Generic;

using DAL.Entities;
using System.Data.Entity;

namespace DAL
{
    public class GroupDAO
    {
        private TourContext db = new TourContext();

        public List<Group> GetAll()
        {
            return db.Groups
                        .OrderByDescending(s => s.EndDate)
                        .ToList();
        }

        public Group GetByID(int ID)
        {
            return db.Groups.Find(ID);
        }

        public List<Group> GetByTourID(int tourID)
        {
            return db.Groups.Where(s => s.TourID == tourID)
                            .OrderByDescending(s => s.EndDate)
                            .ToList();
        }

        public List<DAL.Entities.Group> GetByDate(
            DateTime fromDate, DateTime toDate, DateTime now)
        {
            return db.Groups.Where
                    (
                    s => DbFunctions.TruncateTime(s.StartDate) >= fromDate
                    && DbFunctions.TruncateTime(s.StartDate) <= toDate
                    && DbFunctions.TruncateTime(s.StartDate) <= now
                    )
                    .OrderByDescending(s => s.EndDate)
                    .ToList();
        }

        public string GenerateCode()
        {
            return db.Groups.OrderByDescending(s => s.ID).FirstOrDefault().Code;
        }

        public List<Group> Find(string code, string name, DateTime startDate, DateTime endDate, bool[] array)
        {
            bool a = array[0], b = array[1];

            return db.Groups
                .Where
                (
                    s => DbFunctions.TruncateTime(s.StartDate) >= startDate
                    && DbFunctions.TruncateTime(s.EndDate) <= endDate
                    && (s.Code.Contains(code) || a)
                    && (s.Name.Contains(name) || b)
                )
                .ToList();
        }

        public void Add(Group group)
        {
            db.Groups.Add(group);

            db.SaveChanges();
        }

        public void Update(Group g)
        {
            Group group = db.Groups.Find(g.ID);

            group.Code = g.Code;
            group.TourID = g.TourID;
            group.Name = g.Name;
            group.StartDate = g.StartDate;
            group.EndDate = g.EndDate;
            group.PickupLocation = g.PickupLocation;
            group.DropLocation = g.DropLocation;
            group.Description = g.Description;
            group.Policy = g.Policy;

            db.SaveChanges();
        }

        
    }
}
