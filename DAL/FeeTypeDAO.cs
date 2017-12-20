using System;
using System.Collections.Generic;
using System.Linq;

using DAL.Entities;

namespace DAL
{
    public class FeeTypeDAO
    {
        private TourContext db = new TourContext();

        public List<FeeType> GetAll()
        {
            return db.FeeTypes.ToList();
        }

       
    }
}
