using System.Collections.Generic;

using DAL;
using DAL.Entities;
using System.Linq;

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

        public List<Customer> GetCustomerNotInGroup(int groupID)
        {
            return customerGroupDAO.GetCustomerNotInGroup(groupID);
        }

        public Group Add(CustomerGroup customerGroup)
        {
            // get the current group that customer is put in
            var group = groupDAO.GetByID(customerGroup.GroupID);
            // get all the groups that customer has been in before
            var groups =
                customerGroupDAO.GetByCustomerID(customerGroup.CustomerID);

            foreach (var g in groups)
                // if customer has been already in another group and
                // the time is not suitable, return 0
                if (g.GroupID != group.ID)                   
                    if (group.StartDate >= g.Group.StartDate
                        && group.StartDate <= g.Group.EndDate)
                        return g.Group;

            customerGroupDAO.Add(customerGroup);

            return null;
        }

        public void Delete(CustomerGroup customerGroup)
        {
            customerGroupDAO.Delete(customerGroup);
        }       

       

    }
}
