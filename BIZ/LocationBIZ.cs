using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class LocationBIZ
    {
        LocationDAO locationDAO = new LocationDAO();

        public List<Location> GetAll()
        {
            List<Location> tours = locationDAO.GetAll();
            return tours;
        }        

        public void Add(Location tourLocation)
        {
            locationDAO.Add(tourLocation);
        }

        public void Update(Location tourLocation)
        {
            locationDAO.Update(tourLocation);
        }

        public void Delete(int id)
        {
            locationDAO.Delete(id);
        }

    }
}
