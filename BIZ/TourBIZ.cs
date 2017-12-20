using System.Collections.Generic;

using DAL;
using DAL.Entities;
using System.Text.RegularExpressions;
using System;

namespace BIZ
{
    public class TourBIZ
    {
        TourDAO tourDAO = new TourDAO();

        public List<Tour> GetAll()
        {
            List<Tour> tours = tourDAO.GetAll();
            return tours;
        }

        public Tour GetByID(int id)
        {
            Tour tour = tourDAO.GetByID(id);

            return tour;
        }

        public string GenerateCode()
        {
            string latestCode = tourDAO.GenerateCode();
            string numberPart  = new Regex(@"\D").Replace(latestCode ?? "", "");
            int number = Convert.ToInt32(numberPart);
            string result = "";

            number++;
            if (number < 10)
                result = "T000" + number;
            if (number >= 10 && number < 100)
                result = "T00" + number;
            if (number >= 100 && number < 1000)
                result = "T0" + number;
            if (number >= 1000 && number < 10000)
                result = "T" + number;

            return result;
        }

        public void Add(Tour tour)
        {
            tourDAO.Add(tour);
        }

        public void Update(Tour tour)
        {
            tourDAO.Update(tour);
        }

        public List<Tour> Find(
            string code, 
            string name,
            int tourTypeID,
            int fromCity, 
            int fromDistrict,
            int day, 
            int night,
            string status,
            int minPrice, 
            int maxPrice)
        {
            bool[] array = new bool[] { true, true, true, true, true, true, true, true };
            // 

            if (code != "")
                array[0] = false;
            if (name != "")
                array[1] = false;
            if (tourTypeID != 0)
                array[2] = false;
            if (fromCity != 0)
                array[3] = false;
            if (fromDistrict != 0)
                array[4] = false;
            if (day != 0)
                array[5] = false;
            if (night != 0)
                array[6] = false;
            if (status != "")
                array[7] = false;
            if (maxPrice == 0)
                maxPrice = 1000000000;

            return tourDAO.Find(code, name, tourTypeID, fromCity, fromDistrict, day, night, status,
                minPrice, maxPrice, array);
        }
    }
}
