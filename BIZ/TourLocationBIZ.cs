using System.Collections.Generic;
using System.Linq;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class TourLocationBIZ
    {
        TourLocationDAO tourLocationDAO = new TourLocationDAO();

        public TourLocation Get(int tourID, int locationID)
        {
            return tourLocationDAO.Get(tourID, locationID);
        }

        public List<TourLocation> GetByTourID(int tourID)
        {
            List<TourLocation> tourLocations = tourLocationDAO.GetByTourID(tourID);
            return tourLocations;
        }

        public int GetLatestOrder(int tourID)
        {
            TourLocation location = tourLocationDAO.GetLatestOrder(tourID);
            if (location == null)
                return 1;
            return location.Order;
        }

        public TourLocation CheckIfExisted(TourLocation t)
        {
            TourLocation location = tourLocationDAO.CheckIfExisted(t);
            return location;
        }

        public void Add(TourLocation tourLocation)
        {
            tourLocation.Order = this.GetLatestOrder(tourLocation.TourID);
            tourLocationDAO.Add(tourLocation);
        }

        public void Update(TourLocation tourLocation, int oldOrder)
        {
            tourLocationDAO = new TourLocationDAO();
            var tourLocations = tourLocationDAO.GetByTourID(tourLocation.TourID);
            var t = new TourLocation();
            foreach (var i in tourLocations)
            {
                if (i.Order == tourLocation.Order)
                {
                    t = i;
                }                  
            }
            t.Order = oldOrder;           
            tourLocationDAO.Update(t);

            tourLocationDAO.Update(tourLocation);
        }

        public void Delete(TourLocation t)
        {          
            tourLocationDAO.Delete(t);
        }

    }
}
