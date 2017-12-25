using System.Collections.Generic;
using System;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class GroupHistoryBIZ
    {
        GroupHistoryDAO groupHistoryDAO = new GroupHistoryDAO();

        public List<GroupHistory> GetByGroupIDAndDate(int groupID,
            DateTime fromDate, DateTime toDate)
        {
            return groupHistoryDAO.GetByGroupIDAndDate(groupID, fromDate, toDate);
        }


    }
}
