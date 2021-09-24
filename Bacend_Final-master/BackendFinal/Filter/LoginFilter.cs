using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendFinal.Filter
{
    public class LoginFilter : FilterAttribute,ActionFilter
    {
        private object httpContext;

        public  void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContextWrapper wrap = new HttpContextWrapper(HttpContext.Current);
            var sessioncon = filterContext.HttpContext.Session["username"];
            if (sessioncon == null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary { { "Login", "Log" }, { "action", "Login" } });
            }
        }

        public  void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();

        }
    }

    internal interface ActionFilter
    {
    }
}