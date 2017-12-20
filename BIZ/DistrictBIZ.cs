using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class DistrictBIZ
    {
        DistrictDAO districtDAO = new DistrictDAO();

        public List<District> GetByCityID(int cityID)
        {
            List<District> districts = districtDAO.GetByCityID(cityID);

            return districts;
        }
    }
}
