using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class RoleBIZ
    {
        RoleDAO roleDAO = new RoleDAO();

        public List<Role> GetByGroupID(int groupID)
        {
            return roleDAO.GetByGroupID(groupID);
        }

        public List<Role> GetRole()
        {
            return roleDAO.GetRole();
        }

        public Role CheckDuplicate(Role role)
        {
            return roleDAO.CheckDuplicate(role);
        }

        public List<Role> EmployeeReport(int employeeID)
        {
            return roleDAO.EmployeeReport(employeeID);
        }

        public Group Add(Role role, Group group)
        {
            var roles = roleDAO.GetByEmployeeID(role.EmployeeID);
            foreach (var r in roles)
            {
                if((group.StartDate >= r.Group.StartDate 
                    && group.EndDate <= r.Group.EndDate)
                  ||
                  (group.StartDate <= r.Group.StartDate 
                  && group.EndDate >= r.Group.EndDate)
                  ||
                  (group.StartDate <= r.Group.EndDate
                  && group.EndDate >= r.Group.EndDate)
                  ||
                  (group.StartDate <= r.Group.StartDate
                  && group.EndDate >= r.Group.StartDate)
                  )
                    return r.Group;
            } 
            roleDAO.Add(role);
            return null;
        }

        public void Update(Role r)
        {
            roleDAO.Update(r);
        }

        public void Delete(int id)
        {
            roleDAO.Delete(id);
        }
        public List<Role> Find(string role, int groupID)
        {
            bool[] array = new bool[] { true };
            if (role != "")
            {
                array[0] = false;
            }
            return roleDAO.Find(role, array, groupID);
        }
    }
}