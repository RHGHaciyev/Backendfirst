using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackendFinal.Models;
using System.Web.UI;

namespace BackendFinal.Controllers
{
    public class LogController : Controller
    {
        [Authorize]
        // GET: Log
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View("Error");
        }
        public ActionResult Login()
        {
            return View("Login");
        }
       
        [HttpPost]
        public ActionResult Login(User_reg logs,string returnurl)
        {
            if (ModelState.IsValid)
            {
                using (watcherEntities us = new watcherEntities())
                {
                    var log = us.User_reg.Where(x => x.name.Equals(logs.name) && x.password.Equals(logs.password)).FirstOrDefault();

                    if (log != null)
                    {
                        if (log.roleID == 1 && log.name == logs.name || log.password == logs.password )
                        {
                            Session["username"] = log.name;

                            return RedirectToAction("Home", "Admin","Index");
                        }

                        else if(log.roleID == 2 && log.name == logs.name || log.password == logs.password)
                        {

                            return RedirectToAction("Economy","Main");
                        }

                        else
                        {
                            return View("Error");
                        }
                       
                    }

                      else
                      {
                        return View("Error");
                    }
                   
                }

            }
            return View();
        }
       
    }
}
