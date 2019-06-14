using Chateau_Latour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chateau_Latour.Controllers
{
    public class SingleController : Controller
    {
        // GET: Single
        public ActionResult Single(string controller, string action, int id)
        {         
            TempData["id"] = id;
            return View();
        }

        public JsonResult Load()
        {
            int id = Convert.ToInt32(TempData["id"]);
            LaTuErEntities db = new LaTuErEntities();
            var list = from p in db.E_Commodity
                       join s in db.F_Commoditypictures
                       on p.CommodityId equals s.CommodityId
                       where p.CommodityId == id
                       select new
                       {
                           CommodityId = p.CommodityId,
                           Tradename = p.Tradename,
                           Price = p.Price,
                           CommodityDescription = p.CommodityDescription,
                           Mastergraph = s.Mastergraph
                       };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}