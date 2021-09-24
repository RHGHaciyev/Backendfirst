using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendFinal.Areas.Admin.Controllers
{
    public class AppliesController : Controller
    {
        // GET: Admin/Applies
        public ActionResult Index()
        {
            return View();
        }
    }
}