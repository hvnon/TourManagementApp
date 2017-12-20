using System;
using System.Collections.Generic;
using System.Linq;

using DAL.Entities;

namespace DAL
{
    public class CityDAO
    {
        private TourContext db = new TourContext();

        public List<City> GetAll()
        {
            return db.Cities.ToList();
        }

       
    }
}
