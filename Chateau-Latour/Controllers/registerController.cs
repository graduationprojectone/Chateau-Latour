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
        //[HttpPost]
        //public ActionResult Create(string UserPhone,string UserPwd)
        //{
        //    LaTuErEntities db = new LaTuErEntities();
        //}

    }
}