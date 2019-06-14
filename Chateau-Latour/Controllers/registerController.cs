using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chateau_Latour.Models;

namespace Chateau_Latour.Controllers
{
    public class registerController : Controller
    {
        // GET: register
        public ActionResult register()
        {
            return View();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult TJ(A_UserLogin emp)
        {
            LaTuErEntities db = new LaTuErEntities();
            db.A_UserLogin.Add(emp);
            int rs = db.SaveChanges();
            if (emp != null)
            {
                return RedirectToAction("Login", "Login");
            }
            return RedirectToAction("register");
        }

    }
}