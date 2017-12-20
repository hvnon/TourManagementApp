using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using DAL.Entities;

namespace DAL
{    
    public class LocationDAO
    {
        private TourContext db = new TourContext();

        public List<Location> GetAll()
        {
            return db.Locations
                .ToList();
        }

        public void Add(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
        }

        public void Update(Location t)
        {
            Location location = db.Locations.Find(t.ID);
            location.Name = t.Name;
            location.CityID = t.CityID;
            location.DistrictID = t.DistrictID;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);

            db.SaveChanges();
        }

        
    }
}
