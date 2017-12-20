using System;
using System.Collections.Generic;
using System.Linq;

using DAL.Entities;

namespace DAL
{
    public class TourTypeDAO
    {
        private TourContext db = new TourContext();

        public List<TourType> GetAll()
        {
            return db.TourTypes.ToList();
        }

       
    }
}
