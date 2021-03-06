﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DragonTrax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        // Another comment
        // Comment for test
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddCase()
        {
            ViewBag.Message = "Add a case";
            return View();
        }

        public ActionResult NewEvaluation()
        {
            ViewBag.Message = "See New Evaluation";
            return View();
        }
    }
}
