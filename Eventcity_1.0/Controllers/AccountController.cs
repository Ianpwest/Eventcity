using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventcity.Classes;
using System.Web.Security;

namespace Eventcity.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }


        //
        // GET: /Login/
        public ActionResult Login()
        {
            //Pass in empty login model
            Models.LoginModel lm = new Models.LoginModel();

            return View(lm);
        }

        [HttpPost]
        public ActionResult Login(Eventcity.Models.LoginModel lm)
        {
            if (DatabaseInterface.AccountExists(lm.UserName, lm.Password))
            {
                FormsAuthentication.SetAuthCookie(lm.UserName, lm.RememberMe);

                return RedirectToAction("Index", "Home");
            }

            //Failed to login
            lm.bFailedLogin = true;
            return View(lm);
        }

        //
        // GET: /Register/
        public ActionResult Register()
        {
            //LEFT OFF HERE NEED TO REGISTER PEOPLE TO THE DATABASE
            return View();
        }

        [HttpPost]
        public ActionResult Register(string str)
        {
            return View();
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}
