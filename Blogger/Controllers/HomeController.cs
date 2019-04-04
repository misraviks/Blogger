using Blogger.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Blogger.Controllers
{
    
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            List<MailAddress> mailAddresses = new  List<MailAddress>();
            mailAddresses.Add(new MailAddress("vikas.mishra@globallogic.com", "Vikas Mishra"));
            ViewBag.Message = "Your contact page.";
            if (!new EmailService().SendMail(new MailAddress("mailbot@blogger.com", "Blogger"), mailAddresses, "Test", false, "Test"))
            {
                return View("Error");
            }
            return View();
        }
    }
}