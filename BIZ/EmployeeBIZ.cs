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
        public List<Employee> Find(int id, string identityNumber, string lastName, string firstName)
        {
            bool[] array = new bool[] { true, true, true, true};
            if (id != 0)
            {
                array[0] = false;
            }
            if (identityNumber != "")
            {
                array[1] = false;
            }
            if (lastName != "")
            {
                array[2] = false;
            }
            if (firstName != "")
            {
                array[3] = false;
            }
           
            return employeeDAO.Find(id, identityNumber ,lastName, firstName, array);
        }
    }
}
