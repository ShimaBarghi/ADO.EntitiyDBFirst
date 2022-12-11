using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View("ContactUs");
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult telefon()
        {
            return View();
        }
        public ActionResult zendegi()
        {
            List<string> names = new List<string>();
            names.Add("shima barghi");
            names.Add("homa barghi");
            ViewBag.name = names;




            return View();
        }

        
      
    }
}