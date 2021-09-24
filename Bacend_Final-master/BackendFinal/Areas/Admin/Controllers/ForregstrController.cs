using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackendFinal.Models;

namespace BackendFinal.Controllers
{
    public class ForregstrController : Controller
    {
        // GET: Forregstr
        public ActionResult Registr()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registr(Registr reg)
        {
            if (ModelState.IsValid)
            {
                using(watcherEntities data =new watcherEntities())
                {

                    var EmailRepeating = data.User_reg.Where(x => x.email == reg.email).ToList();
                    if (EmailRepeating.Count > 0)
                    {

                        ModelState.AddModelError("Repeat", "This email has already exist,please change this email");
                    }
                    User_reg user = new User_reg();
                    user.name = reg.name;
                    user.surname = reg.surname;
                    user.age = reg.age;
                    user.email = reg.email;
                    user.phone = reg.phone;
                    user.password = reg.password;
                    data.User_reg.Add(user);  
                    data.SaveChanges();
                   
                    Response.Write("<script>alert(Success,Registration successfully done.)</script>");
                }
            }
            return View();
        }

     
    }
}