using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using DAL.Entities;

namespace DAL
{    
    public class TourLocationDAO
    {
        private TourContext db = new TourContext();

        public TourLocation Get(int tourID, int locationID)
        {
            return db.TourLocations
                .Where(s => s.TourID == tourID && s.LocationID == locationID)
                .FirstOrDefault();
        }

        public List<TourLocation> GetByTourID(int tourID)
        {
            return db.TourLocations
                .Include(s => s.Location)
                .Include(s => s.Location.City)
                .Include(s => s.Location.District)
                .Where(s => s.TourID == tourID)
                .OrderBy(s => s.Order)
                .ToList();
        }

        public TourLocation GetLatestOrder(int tourID)
        {
            return db.TourLocations.Where(s => s.TourID == tourID)
                .OrderByDescending(s => s.Order).FirstOrDefault();
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

        public void Update(TourLocation t)
        {
            TourLocation tourLocation = this.Get(t.TourID, t.LocationID);
            tourLocation.Order = t.Order;

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
