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

        /// <summary>
        /// 商品详情
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 添加商品进购物车
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Add(int id, int count)
        {
            int UserID = Convert.ToInt32(Session["UserID"]);
            LaTuErEntities db = new LaTuErEntities();
            var cart = new ShoppingCart
            {
                UserId = UserID,
                CommodityId = id,
                Quantityofcommodities = count
            };
            db.ShoppingCarts.Add(cart);
            int rs = db.SaveChanges();
            var obj = new { msg = "添加失败", code = 201 };
            if(rs > 0)
            {
                obj = new { msg = "添加成功", code = 200 };
            }
            return Json(obj);
        }
    }
}