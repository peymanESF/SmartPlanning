using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smartPlanning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ورود به حساب کاربری";

            return View("Login");
        }
        public ActionResult startPage()
        {

            return View("index");
        }
    }
}
