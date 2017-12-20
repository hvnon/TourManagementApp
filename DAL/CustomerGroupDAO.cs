using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using DAL.Entities;

namespace DAL
{
    public class CustomerGroupDAO
    {
        private TourContext db = new TourContext();

        public List<CustomerGroup> GetByGroupID(int groupID)
        {
            return db.CustomerGroups
                    .Include(s => s.Customer)
                    .Include(s => s.Group)
                    .Where(s => s.GroupID == groupID)
                    .ToList()
                ;
        }

        public List<CustomerGroup> GetByCustomerID(int customerID)
        {
            return db.CustomerGroups
                    .Include(s => s.Customer)
                    .Include(s => s.Group)
                    .Where(s => s.CustomerID == customerID)
                    .ToList()
                ;
        }

        public CustomerGroup CheckIfCustomerInGroup(int customerID, int groupID)
        {
            return db.CustomerGroups
                    .Where(s => s.CustomerID == customerID && s.GroupID == groupID)
                    .FirstOrDefault()
                ;
        }

        public void Add(CustomerGroup customerGroup)
        {
            db.CustomerGroups.Add(customerGroup);
            db.SaveChanges();
        }

        public void Delete(CustomerGroup c)
        {
            CustomerGroup customerGroup = db.CustomerGroups
                .Where(s => s.CustomerID == c.CustomerID
                && s.GroupID == c.GroupID
            ).FirstOrDefault();

            db.CustomerGroups.Remove(customerGroup);

            db.SaveChanges();
        }
    }
}
