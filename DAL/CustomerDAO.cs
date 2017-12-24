using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using DAL.Entities;

namespace DAL
{
    public class CustomerDAO
    {
        private TourContext db = new TourContext();

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetByID(int id)
        {
            return db.Customers.Find(id);
        }

        public string GenerateCode()
        {
            return db.Customers.OrderByDescending(s => s.ID).FirstOrDefault().Code;
        }

        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Update(Customer c)
        {
            Customer customer = db.Customers.Find(c.ID);

            customer.Code = c.Code;
            customer.LastName = c.LastName;
            customer.FirstName = c.FirstName;
            customer.IdentityNumber = c.IdentityNumber;
            customer.Phone = c.Phone;
            customer.Address = c.Address;
            customer.BirthDate = c.BirthDate;
            customer.Gender = c.Gender;

            db.SaveChanges();
        }

        public List<Customer> Find(List<Customer> customerList, string code, string idnum, string name, string lastname)
        {
            List<Customer> list = new List<Customer>();
            var query = customerList;

            if (name == "")
            {
                query = (from c in customerList
                         where c.IdentityNumber == idnum || c.LastName == lastname || c.Code == code
                         select c).ToList();
            }
            else
            {
                query = (from c in customerList
                         where c.FirstName.Contains(name) || c.IdentityNumber == idnum && c.LastName == lastname || c.Code == code
                         select c).ToList();
            }
            list = query;

            return list;
        }
      
    }
}
