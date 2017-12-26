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
            return db.Roles.Include(s => s.Employee)
                
                .Where(s => s.GroupID == groupID).ToList();
        }

        public List<Role> GetRole()
        {
            return db.Roles.ToList();
        }

        public Role CheckDuplicate(Role r)
        {
            return db.Roles
                .Where(s => s.GroupID == r.GroupID
                && s.EmployeeID == r.EmployeeID)
                .FirstOrDefault();
        }

        public List<Role> EmployeeReport(int employeeID)
        {
            return db.Roles.Include(s => s.Group)
                .Include(s => s.Group.Tour)
                .Where(s => s.EmployeeID == employeeID)
                .ToList();
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
        public List<Role> Find(string vaiTro, bool[] array, int groupID)
        {
            bool a = array[0];
            if(a==true)
            {
                return db.Roles.Include(s => s.Employee).Where(s => s.GroupID == groupID).ToList();
            }
            return db.Roles.Include(s => s.Employee).Where(s => s.GroupID == groupID && s.RoleName.Contains(vaiTro) || a).ToList();
        }
    }
}