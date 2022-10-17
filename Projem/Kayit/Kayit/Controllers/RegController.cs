using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kayit.Models;

namespace Kayit.Controllers
{
    public class RegController : Controller
    {
        ProjemEntities db = new ProjemEntities();
        // GET: Reg
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public ActionResult Register(kayit user)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }
            var yeniKayit = db.kayit.Add(user);
            db.SaveChanges();
            return View("Register");

        }
    }
}