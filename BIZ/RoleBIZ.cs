using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace DAL
{
    public class RoleBIZ
    {
        RoleDAO roleDAO = new RoleDAO();

        public List<Role> GetByGroupID(int groupID)
        {
            return roleDAO.GetByGroupID(groupID);
        }

        public Role CheckDuplicate(Role role)
        {
            return roleDAO.CheckDuplicate(role);
        }

        public void Add(Role role)
        {           
            roleDAO.Add(role);
        }

        public void Update(Role r)
        {
            roleDAO.Update(r);
        }

        public void Delete(int id)
        {
            roleDAO.Delete(id);
        }

    }
}
