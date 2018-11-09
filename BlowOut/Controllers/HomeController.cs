using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is Blow Out all about.";

            return View();
        }

        public ActionResult Rentals()
        {
            ViewBag.Message = "Here are our available options:";

            return View();
        }
    }
}