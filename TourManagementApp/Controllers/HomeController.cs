using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Entities;
using BIZ;

namespace TourManagementApp.Controllers
{
    public class HomeController : Controller
    {        
        TourBIZ tourBIZ = new TourBIZ();
        TourTypeBIZ tourTypeBIZ = new TourTypeBIZ();

 
        public ActionResult Index(FormCollection form)
        {
            ViewBag.TourTypes = new SelectList(tourTypeBIZ.GetAll(), "ID", "Name");
            var tourList = tourBIZ.GetAll();           
            try
            {
                if (Request.Form["resetTourForm"] != null)
                {
                    
                    return RedirectToAction("Index");
                }
                if (Request.Form["findTour"] != null)
                {
                    string code = form["code"].ToString();
                    string name = form["name"].ToString();
                    int tourTypeID = 0;
                    string tourType = form["tourType"].ToString();
                    if(tourType != "")
                    {
                        tourTypeID = Convert.ToInt32(tourType);
                    }
                    int cityID = 0, districtID = 0;
                    int d, n, day = 0, night = 0, min, max, minPrice = 0, maxPrice = 0;
                    if (Int32.TryParse(form["day"].ToString(), out d))
                        day = d;
                    if (Int32.TryParse(form["night"].ToString(), out n))
                        night = n;
                    if (Int32.TryParse(form["minPrice"].ToString(), out min))
                        minPrice = min;
                    if (Int32.TryParse(form["maxPrice"].ToString(), out max))
                        maxPrice = max;
                    string status = "";

                    var result = tourBIZ.Find(code, name, tourTypeID, cityID, districtID, day, night, status, minPrice, maxPrice);


                    return View(result);
                }
                else
                {
                    return View(tourList);
                }

            }
            catch
            {
                return View(tourList);
            }
        }
 
        // GET: Tours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Tour tour = tourBIZ.GetByID((int)id);

            GroupBIZ gbiz = new GroupBIZ();
            ViewBag.groupInTour = gbiz.GetByTourID((int)id);

            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }
                                      
    }
}
