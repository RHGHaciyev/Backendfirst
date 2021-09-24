using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendFinal.Areas.Admin.Controllers
{
    public class SiteSettingsController : Controller
    {
        // GET: Admin/SiteSettings
        public ActionResult Index()
        {
            return View();
        }
    }
}