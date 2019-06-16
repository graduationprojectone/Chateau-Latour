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
        public JsonResult Load()
        {
            //订单
            LaTuErEntities db = new LaTuErEntities();
            var list =db.J_OrderXX.ToList()
                      .Select(c => new
                      {
                          OrderxxId=c.OrderId ,
                          CommodityId = c.A_UserLogin.UserName,
                          Tradename=c.Tradename,
                          Ordertime= DateTime.Now.ToString("yyyy-MM-dd"),
                          PaymentmethodId =c.PaymentmethodId,
                          Itempricing=c.Itempricing,
                          Commoditypictures=c.Commoditypictures,
                          UserId=c.UserId,
                          Quantityofcommodities=c.Quantityofcommodities,
                          Orderstatus=c.Orderstatus,
                          OrderId=c.OrderId
                      }).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}