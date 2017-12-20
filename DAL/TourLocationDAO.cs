using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using DAL.Entities;

namespace DAL
{    
    public class TourLocationDAO
    {
        private TourContext db = new TourContext();

        public List<TourLocation> GetByTourID(int tourID)
        {
            return db.TourLocations
                .Include(s => s.Location)
                .Include(s => s.Location.City)
                .Include(s => s.Location.District)
                .Where(s => s.TourID == tourID).ToList();
        }

        public TourLocation CheckIfExisted(TourLocation t)
        {
            return db.TourLocations
                .Where(s => s.TourID == t.TourID && s.LocationID == t.LocationID).FirstOrDefault();
        }

        public void Add(TourLocation tourLocation)
        {
            db.TourLocations.Add(tourLocation);
            db.SaveChanges();
        }

        public void Update(TourLocation t, int oldLocationID)
        {
            TourLocation tourLocation = db.TourLocations
                .Where(s => s.TourID == t.TourID && s.LocationID == oldLocationID).FirstOrDefault();
            db.TourLocations.Remove(tourLocation);
            db.TourLocations.Add(t);
            db.SaveChanges();

        }

        public void Delete(TourLocation tourLocation)
        {
            TourLocation t = db.TourLocations.Where(s => s.TourID == tourLocation.TourID
                && s.LocationID == tourLocation.LocationID
            ).FirstOrDefault();

            db.TourLocations.Remove(t);

            db.SaveChanges();
        }

        
    }
}
