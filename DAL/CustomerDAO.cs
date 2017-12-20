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


        public Customer Find(
            string identityNumber, 
            string firstName, 
            string lastName
            )
        {

            return db.Customers.Where(
                s => s.IdentityNumber == identityNumber
                && s.LastName == lastName
                && s.FirstName == firstName
                )
                .FirstOrDefault();
        }
    }
}
