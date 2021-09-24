using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using BackendFinal.Models;

namespace BackendFinal.Controllers
{
    
    public class MainController : Controller
    {
        private watcherEntities db = new watcherEntities();

        public ActionResult Economy()
        {
            ViewBag.one = db.C_News_category.Find(2);
            ViewBag.Eco = db.C_News_category.ToList().Where(x => x.type_id == 1).Skip(1).Take(2);
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult Interesting()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList()); 
        }
        public ActionResult health()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult Sport()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult Social()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult World()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult Criminal()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult HeadPage()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult Team()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }
        public ActionResult Contact()
        {
            var main = (from d in db.C_News_category select d).ToList();
            return View(main.ToList());
        }


    }
}