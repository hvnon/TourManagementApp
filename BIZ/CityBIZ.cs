using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class CityBIZ
    {
        CityDAO cityDAO = new CityDAO();

        public List<City> GetAll()
        {
            List<City> cities = cityDAO.GetAll();

            return cities;
        }      
    }
}
