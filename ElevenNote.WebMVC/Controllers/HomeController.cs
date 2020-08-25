using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ElevenNote MVC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ElevenNote MVC contact page.";

            return View();
        }
    }
}