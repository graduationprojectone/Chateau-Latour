﻿using Chateau_Latour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chateau_Latour.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Load()
        {
            LaTuErEntities db = new LaTuErEntities();
            var list = db.
        }
    }
}