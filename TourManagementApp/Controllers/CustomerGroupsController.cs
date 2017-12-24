using System;
using System.Collections.Generic;
using System.Web.Mvc;

using DAL.Entities;
using BIZ;

namespace TourManagementApp.Controllers
{
    public class CustomerGroupsController : Controller
    {
        CustomerGroupBIZ customerGroupBIZ = new CustomerGroupBIZ();
        CustomerBIZ customerBIZ = new CustomerBIZ();
        GroupBIZ groupBIZ = new GroupBIZ();

        public ActionResult Index(int? groupID, FormCollection form)
        {
            int gID = 0;
            if (groupID == 0)
                gID = Convert.ToInt32(form["groupID"].ToString());
            else gID = (int)groupID;
            List<Customer> customerList = customerGroupBIZ.GetCustomerNotInGroup(gID);

            ViewBag.group = groupBIZ.GetByID((int)groupID);

            if (Request.Form["resetCustomerForm"] != null)
            {
                return RedirectToAction("../CustomerGroups/Index/" + groupID);
            }

            if (Request.Form["findCustomer"] != null)
            {
                string code = form["code"].ToString().Trim();
                string firstName = form["firstName"].ToString().Trim();              
                string lastName = form["lastName"].ToString().Trim();
                string identityNumber = form["identityNumber"].ToString().Trim();


                if (firstName == "" && identityNumber == "" && lastName == "" && code == "")
                {
                    return View(customerList);
                }

                var result = customerBIZ.Find(customerList, code, identityNumber, firstName, lastName);

                return View(result);


            }
            else
            {
                return View(customerList);
            }
        }

        public ActionResult Add(int customerID, int groupID)
        {

            CustomerGroup customerGroup = new CustomerGroup() {
                CustomerID = customerID,
                GroupID = groupID
            };

            var result = customerGroupBIZ.Add(customerGroup); ;

            if (result == null)
            {                
                return RedirectToAction("Index", new { groupID = groupID});
            }
            else
            {
                TempData["msg"] = 
                "<script>alert('Khách này đã ở trong đoàn "+ result.Code + " - " + result.Name
                + " - Ngày đi:" + result.StartDate + "- Ngày về:" + result.EndDate +"');</script>";

                return RedirectToAction("Index", new { groupID = groupID });                
            }
        }

        public ActionResult Delete(int customerID, int groupID)
        {
            var customerGroup = new CustomerGroup()
            {
                CustomerID = customerID,
                GroupID = groupID
            };
            customerGroupBIZ.Delete(customerGroup);

            return RedirectToAction("../Groups/Details/" + groupID);
        }


    }
}
