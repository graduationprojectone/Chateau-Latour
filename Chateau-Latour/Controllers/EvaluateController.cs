using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chateau_Latour.Models;

namespace mvc2.Controllers
{
    public class EvaluateController : Controller
    {
        // GET: Evaluate
        public ActionResult Evaluate()
        {
            return View();
        }
        public JsonResult Load()
        {
            //评价
            LaTuErEntities db = new LaTuErEntities();
            var list = db.J_OrderXX.ToList()
                      .Select(c => new
                      {
                          OrderxxId = c.OrderId,
                          CommodityId = c.A_UserLogin.UserName,
                          Tradename = c.Tradename,
                          Ordertime = DateTime.Now.ToString("yyyy-MM-dd"),
                          PaymentmethodId = c.PaymentmethodId,
                          Itempricing = c.Itempricing,
                          Commoditypictures = c.Commoditypictures,
                          UserId = c.UserId,
                          Quantityofcommodities = c.Quantityofcommodities,
                          Orderstatus = c.Orderstatus,
                          OrderId = c.OrderId
                      }).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}