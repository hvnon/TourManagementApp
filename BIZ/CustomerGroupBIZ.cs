using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class CustomerGroupBIZ
    {
        CustomerGroupDAO customerGroupDAO = new CustomerGroupDAO();
        GroupDAO groupDAO = new GroupDAO();
 
        public List<CustomerGroup> GetByGroupID(int groupID)
        {
            return customerGroupDAO.GetByGroupID(groupID);
        }

        public int Add(CustomerGroup customerGroup)
        {
            // check if customer has already been in specific group
            var isExisted = 
                customerGroupDAO.CheckIfCustomerInGroup(customerGroup.CustomerID, customerGroup.GroupID);
            if (isExisted != null)
                return 0;
            else
            {
                var group = groupDAO.GetByID(customerGroup.GroupID);
                var chosenGroups = customerGroupDAO.GetByCustomerID(customerGroup.CustomerID);
                foreach (var g in chosenGroups)
                    if (group.StartDate >= g.Group.StartDate
                            && group.StartDate <= g.Group.StartDate)
                        return -1;    
                
            }

            customerGroupDAO.Add(customerGroup);

            return 1;
        }

        public void Delete(CustomerGroup customerGroup)
        {
            customerGroupDAO.Delete(customerGroup);
        }

    }
}
