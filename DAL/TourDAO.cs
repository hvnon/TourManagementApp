using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

using DAL.Entities;
using System;

namespace DAL
{
    public class TourDAO
    {
        private TourContext db = new TourContext();

        public List<Tour> GetAll()
        {
            List<Tour> tours = db.Tours
                .Include(s => s.TourType)
                .Include(s => s.City)
                .Include(s => s.District)
                .ToList();
            return tours;
        }

        public Tour GetByID(int id)
        {
            Tour tour = db.Tours
                 .Include(s => s.TourType)
                 .Include(s => s.City)
                 .Include(s => s.District)
                 .Where(s => s.ID == id).FirstOrDefault();

            return tour;
        }
        public string GenerateCode()
        {
            return db.Tours.OrderByDescending(s => s.ID).FirstOrDefault().Code;
        } 

        public void Add(Tour tour)
        {

            db.Tours.Add(tour);

            db.SaveChanges();

            db.TourPriceHistories.Add(new TourPriceHistory()
                {
                    TourID = tour.ID,
                    Price = tour.Price,
                    Date = DateTime.Now
                } );

            db.SaveChanges();
        }

        public void Update(Tour t)
        {
            var tour = db.Tours.Find(t.ID);

            tour.Code = t.Code;
            tour.Name = t.Name;
            tour.TourTypeID = t.TourTypeID;
            tour.FromCity = t.FromCity;
            tour.FromDistrict = t.FromDistrict;
            tour.Day = t.Day;
            tour.Night = t.Night;
            tour.Status = t.Status;
            tour.Price = t.Price;
            tour.Description = t.Description;

            db.SaveChanges();

            db.TourPriceHistories.Add(new TourPriceHistory()
            {
                TourID = tour.ID,
                Price = tour.Price,
                Date = DateTime.Now
            });

            db.SaveChanges();
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
            int maxPrice, 
            bool[] array)
        {
            bool a = array[0], b = array[1], c = array[2], d = array[3], e = array[4]
                , f = array[5], g = array[6], h = array[7];

            List<Tour> tour = db.Tours.Where
                (
                    s => 
                       (s.Code.Contains(code) ||  a)
                    && (s.Name.Contains(name) || b)
                    && (s.TourTypeID == tourTypeID || c)
                    && (s.FromCity == fromCity || d)
                    && (s.FromDistrict == fromDistrict || e)
                    && (s.Day == day || f)
                    && (s.Night == night || g)
                    && (s.Status == status || h)
                    && s.Price >= minPrice
                    && s.Price <= maxPrice    
                ).ToList();

            return tour;
        }
    }
}
