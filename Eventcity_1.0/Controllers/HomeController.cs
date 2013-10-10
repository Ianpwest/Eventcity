using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eventcity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View("~/Views/Home/TestHomePage.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestHomePage()
        {
            return View();
        }

        public PartialViewResult PartialTabContent(string strPageName)
        {
            switch (strPageName)
            {
                case "WhatsHappening":
                    return PartialView("PartialWhatsHappening");
                case "FindEvents":
                    return PartialView("PartialFindEvents");
                case "Calendar":
                    return PartialView("PartialCalendar");
                case "Notifications":
                    return PartialView("PartialNotifications");
                default:
                    break;
            }

            return null;
        }
    }
}

