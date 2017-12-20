using System;
using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class TourTypeBIZ
    {
        TourTypeDAO tourTypeDAO = new TourTypeDAO();

        public List<TourType> GetAll()
        {
            List<TourType> tourTypes = tourTypeDAO.GetAll();
            return tourTypes;
        }

        
    }
}
