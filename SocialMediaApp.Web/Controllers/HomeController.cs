﻿using System.Web.Mvc;

namespace SocialMediaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ProfileSetup()
        {
            return View();
        }
    }
}