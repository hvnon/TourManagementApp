using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class GroupFeeBIZ
    {
        GroupFeeDAO groupFeeDAO = new GroupFeeDAO();

        public List<GroupFee> GetByGroupID(int groupID)
        {
            List<GroupFee> groups = groupFeeDAO.GetByGroupID(groupID);
            return groups;
        }

        public void Add(GroupFee groupFee)
        {
            groupFeeDAO.Add(groupFee);
        }

        public void Update(GroupFee groupFee)
        {
            groupFeeDAO.Update(groupFee);
        }

        public void Delete(int id)
        {
            groupFeeDAO.Delete(id);
        }

        public List<GroupFee> SortByFeeType()
        {
            return groupFeeDAO.SortByFeeType();
        }
    }
}
