﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNOAClient.Controllers
{
    public class HomeController : Controller
    {
        // [Authorize]
        public ActionResult Index()
        {
            ViewBag.Message = "Nature Client Server";

            return View();
        }
    }
}
