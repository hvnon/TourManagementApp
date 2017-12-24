using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

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

        public string GenerateCode()
        {
            string latestCode = customerDAO.GenerateCode();
            string numberPart = new Regex(@"\D").Replace(latestCode ?? "", "");
            int number = Convert.ToInt32(numberPart);
            string result = "";

            number++;
            if (number < 10)
                result = "KH000" + number;
            if (number >= 10 && number < 100)
                result = "KH00" + number;
            if (number >= 100 && number < 1000)
                result = "KH0" + number;
            if (number >= 1000 && number < 10000)
                result = "KH" + number;

            return result;
        }

        public void Add(Customer customer)
        {
            customerDAO.Add(customer);
        }

        public void Update(Customer customer)
        {
            customerDAO.Update(customer);
        }


        public List<Customer> Find(List<Customer> customerList, string code, string identityNumber, string firstName, string lastName)
        {
            return customerDAO
                .Find(customerList, code, identityNumber, firstName, lastName); ;
        }      
    }
}
