using System.Collections.Generic;

using DAL;
using DAL.Entities;
using System.Text.RegularExpressions;
using System;

namespace BIZ
{
    public class GroupBIZ
    {
        GroupDAO groupDAO = new GroupDAO();

        public List<DAL.Entities.Group> GetAll()
        {
            List<DAL.Entities.Group> groups = groupDAO.GetAll();

            return groups;
        }

        public DAL.Entities.Group GetByID(int id)
        {
            DAL.Entities.Group group = groupDAO.GetByID(id);

            return group;
        }

        public List<DAL.Entities.Group> GetByTourID(int tourID)
        {
            List<DAL.Entities.Group> groups = groupDAO.GetByTourID(tourID);

            return groups;
        }

        public string GenerateCode()
        {
            string latestCode = groupDAO.GenerateCode();
            string numberPart  = new Regex(@"\D").Replace(latestCode ?? "", "");
            int number = Convert.ToInt32(numberPart);
            string result = "";

            number++;
            if (number < 10)
                result = "D000" + number;
            if (number >= 10 && number < 100)
                result = "D00" + number;
            if (number >= 100 && number < 1000)
                result = "D0" + number;
            if (number >= 1000 && number < 10000)
                result = "D" + number;

            return result;
        }

        public List<DAL.Entities.Group> Find(
            string code,
            string name,
            DateTime startDate,
            DateTime endDate
            )
        {
            bool[] array = new bool[] { true, true };

            if (code != "")
                array[0] = false;
            if (name != "")
                array[1] = false;

            TimeSpan time1 = new TimeSpan(00, 00, 00);
            startDate = startDate.Date + time1;
            TimeSpan time2 = new TimeSpan(23, 59, 59);
            endDate = endDate.Date + time2;

            return groupDAO.Find(code, name, startDate, endDate, array);
        }

        public void Add(DAL.Entities.Group group)
        {
            groupDAO.Add(group);
        }

        public void Update(DAL.Entities.Group group)
        {
            groupDAO.Update(group);
        }       
    }
}
