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
            List<Eventcity.Models.events> lstEvents = Classes.DatabaseInterface.GetAllEvents();

            return View("~/Views/Home/TestHomePage.cshtml", lstEvents);
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

        public PartialViewResult PartialTabContent(string strPageName)
        {
            switch (strPageName)
            {
                case "WhatsHappening":
                    List<Eventcity.Models.events> lstEvents = Classes.DatabaseInterface.GetAllEvents();
                    return PartialView("PartialWhatsHappening", lstEvents);
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

