using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contact
        public ActionResult Email(string name, string email)
        {
            ViewBag.content = "Thank you " + name + ". We will send an email to " + email;
            ViewBag.email = email;
            ViewBag.name = name;

            return View();
        }
    }
}
