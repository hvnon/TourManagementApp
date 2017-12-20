using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using DAL.Entities;

namespace DAL
{
    public class RoleDAO
    {
        private TourContext db = new TourContext();

        public List<Role> GetByGroupID(int groupID)
        {
            return db.Roles.Where(s => s.GroupID == groupID).ToList();
        }

        public Role CheckDuplicate(Role r)
        {
            return db.Roles
                .Where(s => s.GroupID == r.GroupID 
                && s.EmployeeID == r.EmployeeID)
                .FirstOrDefault();
        }

        public void Add(Role role)
        {
            db.Roles.Add(role);
            db.SaveChanges();
        }

        public void Update(Role r)
        {
            Role role = db.Roles.Find(r.ID);
            role.RoleName = r.RoleName;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Roles.Remove(db.Roles.Find(id));

            db.SaveChanges();
        }

    }
}
