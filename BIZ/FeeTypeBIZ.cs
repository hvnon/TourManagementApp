using System.Collections.Generic;

using DAL;
using DAL.Entities;

namespace BIZ
{
    public class FeeTypeBIZ
    {
        FeeTypeDAO feeTypeDAO = new FeeTypeDAO();

        public List<FeeType> GetAll()
        {
            List<FeeType> feeTypes = feeTypeDAO.GetAll();

            return feeTypes;
        }      
    }
}
