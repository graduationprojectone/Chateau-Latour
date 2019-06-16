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
    }
}