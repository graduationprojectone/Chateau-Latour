using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chateau_Latour.Models;

namespace mvc2.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Order()
        {
            return View();
        }

    }
}