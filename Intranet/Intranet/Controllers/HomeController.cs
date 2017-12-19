using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Team_Pages()
        {
            ViewBag.Message = "Find your team page below!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CrisisTeam()
        {
            return View();
        }






        //TeamPages Links
        public ActionResult Accounts()
        {
            return View();
        }

        public ActionResult AlbatrossEuropa()
        {
            return View();
        }
    }
}