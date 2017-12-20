using System.Collections.Generic;
using System.Linq;

using DAL.Entities;

namespace DAL
{
    public class DistrictDAO
    {
        private TourContext db = new TourContext();

        public List<District> GetByCityID(int cityID)
        {
            return db.Districts.Where(s => s.CityID == cityID).ToList();
        }

       
    }
}
