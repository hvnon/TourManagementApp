using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class CustomerBIZ
    {
        CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> GetAll()
        {
            return customerDAO.GetAll();
        }

        public Customer GetByID(int id)
        {
            return customerDAO.GetByID(id);
        }


        public void Add(Customer customer)
        {
            customerDAO.Add(customer);
        }

        public void Update(Customer customer)
        {
            customerDAO.Update(customer);
        }


        public Customer Find(
            string identityNumber,
            string firstName,
            string lastName
            )
        {

            return customerDAO.Find(identityNumber, firstName, lastName);
        }
    }
}
