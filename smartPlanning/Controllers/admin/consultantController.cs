using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace smartPlanning.Controllers.admin
{
    public class consultantController : Controller
    {
        public ActionResult create()
        {
            return View("addConsultant");
        }

        [HttpPost]
        public void create(Models.consultant cs)
        {

        }
    }
}
