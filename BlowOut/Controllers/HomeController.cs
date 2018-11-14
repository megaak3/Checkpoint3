using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.DAL;
using BlowOut.Models;


//Made by Andrew Keeley, Eric Beecher, Josh Smith, Danny Guzman
//This is the Home Controller
namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        private InstrumentContext db = new InstrumentContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Rentals()
        {
            return View();
        }

        // GET: Insturment
        public ActionResult Instrument(string id)
        {
            switch (id)
            {
                case "Trumpet":
                    ViewBag.New = "55";
                    ViewBag.Used = "25";
                    break;
                case "Trombone":
                    ViewBag.New = "60";
                    ViewBag.Used = "35";
                    break;
                case "Tuba":
                    ViewBag.New = "70";
                    ViewBag.Used = "50";
                    break;
                case "Flute":
                    ViewBag.New = "40";
                    ViewBag.Used = "25";
                    break;
                case "Clarinet":
                    ViewBag.New = "35";
                    ViewBag.Used = "27";
                    break;
                case "Saxaphone":
                    ViewBag.New = "42";
                    ViewBag.Used = "30";
                    break;

            }


            ViewBag.Insturment = id;
            ViewBag.Image = id + ".jpg";
            return View();
        }
    }
}