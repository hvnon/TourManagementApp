using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace DAL
{
    public class EmployeeDAO
    {
        private TourContext db = new TourContext();
        public List<Employee> GetEmployee()
        {
            return db.Employees.ToList();
        }

        public Employee GetByID(int id)
        {
            return db.Employees.Find(id);
        }

        public void Add(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
        }

        public void Update(Employee emp)
        {
            Employee em = db.Employees.Find(emp.ID);
            em.LastName = emp.LastName;
            em.FirstName = emp.FirstName;
            em.IdentityNumber = emp.IdentityNumber;
            em.Phone = emp.Phone;
            em.Address = emp.Address;
            em.BirthDate = emp.BirthDate;
            em.Gender = emp.Gender;
            db.SaveChanges();
        }
        public List<Employee> Find(int id, string identityNumber, string lastName, string firstName,
            bool[] array)
        {
            bool a = array[0], b = array[1], c = array[2], d = array[3];
 
            List<Employee> emp = db.Employees.Where
                (
                    s => (s.ID == id || a)
                    && (s.IdentityNumber.Contains(identityNumber) || b)
                    && (s.FirstName.Contains(firstName) || d)
                    && (s.LastName.Contains(lastName) || c)                  
                ).ToList();
            return emp;
        }
    }
}
