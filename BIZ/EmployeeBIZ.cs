using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BIZ
{
    public class EmployeeBIZ
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public List<Employee> GetAll()
        {
            return employeeDAO.GetEmployee();
        }

        public Employee GetByID(int id)
        {
            return employeeDAO.GetByID(id);
        }

        public void Add(Employee emp)
        {
            employeeDAO.Add(emp);
        }

        public void Update(Employee emp)
        {
            employeeDAO.Update(emp);
        }
        public List<Employee> Find(string id, string lastName, string firstName, string address, string identityNumber, string phone, DateTime DOB, bool gender)
        {
            bool[] array = new bool[] { true, true, true, true, true, true};
            if (id != "")
            {
                array[0] = false;
            }
            if (lastName != "")
            {
                array[1] = false;
            }
            if (firstName != "")
            {
                array[2] = false;
            }
            if (address != "")
            {
                array[3] = false;
            }
            if (identityNumber != "")
            {
                array[4] = false;
            }
            if (phone != "")
            {
                array[5] = false;
            }
            return employeeDAO.Find(id, lastName, firstName, address, identityNumber, phone, DOB, gender, array);
        }
    }
}
