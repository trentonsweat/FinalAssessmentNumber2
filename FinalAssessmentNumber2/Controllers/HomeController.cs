using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalAssessmentNumber2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            NorthWindEntities ORM = new NorthWindEntities(); // define ORM

            ORM.Customers.ToList();

            List<Customer> CustomerList = ORM.Customers.ToList(); // select * from cusomers

            ViewBag.Message = "Your application description page.";

            ViewBag.Clist = CustomerList; // sending the list of customers to the view

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}