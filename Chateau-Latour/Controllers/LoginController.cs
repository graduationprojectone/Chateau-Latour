using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chateau_Latour.Models;

namespace Chateau_Latour.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string txt_id, string txt_pwd)
        {
            LaTuErEntities db = new LaTuErEntities();
            var emp = db.A_UserLogin
                .Where(c => c.UserPhone == txt_id && c.UserPwd == txt_pwd)
                .FirstOrDefault();
            if (emp != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login");
        }
    }
}