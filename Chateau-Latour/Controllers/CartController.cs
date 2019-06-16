using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chateau_Latour.Models;

namespace Chateau_Latour.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        //购物车页面
        public ActionResult Cart()
        {
            return View();
        }

        /// <summary>
        /// 加载当前用户的购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Load()
        {
            int UserID = Convert.ToInt32(Session["UserID"]);
            LaTuErEntities db = new LaTuErEntities();
            var list = from p in db.ShoppingCarts
                       join s in db.E_Commodity
                       on p.CommodityId equals s.CommodityId
                       where p.UserId == UserID
                       select new
                       {
                           p.ShoppingCartId,
                           s.Tradename,
                           s.Price,
                           s.Image,
                           s.CommodityId
                       };
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        //订单页面
        public ActionResult Order()
        {
            return View();
        }

        public JsonResult UserOrder()
        {
            int UserID = Convert.ToInt32(Session["UserID"]);
            LaTuErEntities db = new LaTuErEntities();
            var list = from p in db.J_OrderXX
                       join s in db.E_Commodity
                       on p.CommodityId equals s.CommodityId
                       where p.UserId == UserID
                       select new
                       {
                           p.OrderId,
                           s.Tradename,
                           s.Price,
                           s.Image
                       };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}