using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace smartPlanning.Controllers.admin
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public int Validation(string username,string password)
        {
            blStudent blstd = new blStudent();
            if (blstd.login(username, password) !=0)
            {
                return blstd.login(username, password);
            }
            else
            {
                return 0;
            }
        }
    }
}