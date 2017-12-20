using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class TourLocationBIZ
    {
        TourLocationDAO tourLocationDAO = new TourLocationDAO();

        public List<TourLocation> GetByTourID(int tourID)
        {
            List<TourLocation> tourLocations = tourLocationDAO.GetByTourID(tourID);
            return tourLocations;
        }

        public TourLocation CheckIfExisted(TourLocation t)
        {
            TourLocation location = tourLocationDAO.CheckIfExisted(t);
            return location;
        }

        public void Add(TourLocation tourLocation)
        {
            tourLocationDAO.Add(tourLocation);
        }

        public void Update(TourLocation tourLocation, int oldLocationID)
        {
            tourLocationDAO.Update(tourLocation, oldLocationID);
        }

        public void Delete(TourLocation t)
        {          
            tourLocationDAO.Delete(t);
        }

    }
}
