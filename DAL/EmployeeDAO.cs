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
        public List<Employee> Find(string id, string ho, string ten, string diachi, string cmnd, string sdt, DateTime nsinh, bool gt, bool[] array)
        {
            bool a = array[0], b = array[1], c = array[2], d = array[3], e = array[4], f = array[5];
            int IDNV = int.Parse(id);
            List<Employee> emp = db.Employees.Where
                (
                    s => (s.ID == IDNV || a)
                    && (s.FirstName.Contains(ho) || b)
                    && (s.LastName.Contains(ten) || c)
                    && (s.Address.Contains(diachi) || d)
                    && (s.IdentityNumber.Contains(cmnd) || e)
                    && (s.Phone.Contains(sdt) || f)
                    && (s.BirthDate == nsinh)
                    && (s.Gender == gt)
                ).ToList();
            return emp;
        }
    }
}
