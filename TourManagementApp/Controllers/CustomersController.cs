using System.Net;
using System.Web.Mvc;

using DAL.Entities;
using BIZ;

namespace TourManagementApp.Controllers
{
    public class CustomersController : Controller
    {
        CustomerBIZ customerBIZ = new CustomerBIZ();


        public ActionResult Index(FormCollection form)
        {
            var customerList = customerBIZ.GetAll();
            try
            {
                if (Request.Form["resetCustomerForm"] != null)
                {
                    return RedirectToAction("Index");
                }

                if (Request.Form["findcus"] != null)
                {
                    string code = form["code"].ToString().Trim();
                    string name = form["name"].ToString().Trim();
                    string idnum = form["idnum"].ToString().Trim();
                    string lastname = form["lastname"].ToString().Trim();



                    if (name == "" && idnum == "" && lastname == "" && code == "")
                    {
                        return View(customerList);
                    }

                    var query = customerBIZ.Find(customerList,code, idnum, name, lastname);

                    return View(query);

                }
                else
                {
                    return View(customerList);
                }

            }
            catch
            {
                return View(customerList);
            }
        }


        public ActionResult Create()
        {
            ViewBag.code = customerBIZ.GenerateCode();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code,LastName,FirstName,IdentityNumber,Phone,Address,BirthDate,Gender")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerBIZ.Add(customer);

                return RedirectToAction("Index");
            }

            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = customerBIZ.GetByID(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Code,LastName,FirstName,IdentityNumber,Phone,Address,BirthDate,Gender")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerBIZ.Update(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

       
    }
}
