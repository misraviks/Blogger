using Blogger.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blogger.Controllers
{
   // [UserAuthenticationFilter]
    public class BaseController : Controller
    {
        // GET: Base
        private ActionResult CheckSession()
        {
            if (System.Web.HttpContext.Current.Session["User"] == null)
            {
                return RedirectToAction("Index", "SessionTimeOut");
            }
            else
            {
                ViewBag.ServerDT = "Server Date & Time : " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt");
                ViewBag.Version = "version : 1.0.0.1";
             
                return View();
            }
        }

    }
}