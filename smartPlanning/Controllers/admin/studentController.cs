using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using BE;
using BLL;
using Newtonsoft.Json.Linq;

namespace smartPlanning.Controllers.admin
{
    public class studentController : Controller
    {
        public ActionResult index()
        {
            return View();
        }
        
        public ActionResult create()
        {
            return View("addStudent");
        }
        public ActionResult showAll()
        {
            blStudent blstd = new blStudent();
            return View("showAll",blstd.read());
        }

        [HttpPost]
        public ActionResult create(Models.student std)
        {

            blStudent blStd = new blStudent();
            BE.student beStd = new student();


            beStd.stName = std.stName;      
            beStd.stFamily = std.stFamily;      
            beStd.gender = std.gender;      
            beStd.email = std.email;      
            beStd.stPic = upload(std.stPic);       
            beStd.stPaye = std.stPaye;      
            beStd.stAverage = std.stAverage;      
            beStd.stClassNum = std.stClassNum;      
            beStd.stPhoneNumber = std.stPhoneNumber;      
            beStd.stTel = std.stTel;      
            beStd.stFatherNum = std.stFatherNum;      
            beStd.stMotherNum = std.stMotherNum;      
            beStd.stAddress = std.stAddress;      
            beStd.stStrengthsPoint = std.stStrengthsPoint;      
            beStd.stWeakPoint = std.stWeakPoint;      
            beStd.stFavoriteLesson = std.stFavoriteLesson;      
            beStd.stHateLesson = std.stHateLesson;      
            beStd.stUserName = std.stUserName;      
            beStd.stPassWord = std.stPassWord;      


            blStudent blstd = new blStudent();
            blstd.create(beStd);
            return View("addStudent");
        }
        [HttpPost]
        public string  upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                // extract only the filename
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/uploads/images/students"), fileName);
                file.SaveAs(path);
                return fileName;

            }
            return "Error while uploadind picture!!!";
        }
        public ActionResult stjson()
        {
            //return Json(new { redirect = "search" }, JsonRequestBehavior.AllowGet);
            return Json(new { redirect = "stSearch" }, JsonRequestBehavior.AllowGet);
        }
       
        public ActionResult stSearch(string tag)
        {
            
            //JArray jsonArray = JArray.Parse(tags);
            //dynamic data = JObject.Parse(jsonArray[0].ToString());
            //List<string> split = new List<string>();
            //foreach (dynamic item in jsonArray)
            //{
            //    split.Add(item.tag.Tostring());
            //}
            blStudent blstd = new blStudent();
            List<student> lstd = blstd.search(tag);
            
            return View("showAll",lstd);
        }
        
        [HttpPost]
        public ActionResult show(int id)
        {
            blStudent blStd = new blStudent();

            return Json(blStd.show(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult update(Models.student std)
        {

            blStudent blStd = new blStudent();
            BE.student beStd = new student();

            beStd.id = std.id;
            beStd.stName = std.stName;
            beStd.stFamily = std.stFamily;
            beStd.gender = std.gender;
            beStd.email = std.email;
            beStd.stPic = upload(std.stPic);
            beStd.stPaye = std.stPaye;
            beStd.stAverage = std.stAverage;
            beStd.stClassNum = std.stClassNum;
            beStd.stPhoneNumber = std.stPhoneNumber;
            beStd.stTel = std.stTel;
            beStd.stFatherNum = std.stFatherNum;
            beStd.stMotherNum = std.stMotherNum;
            beStd.stAddress = std.stAddress;
            beStd.stStrengthsPoint = std.stStrengthsPoint;
            beStd.stWeakPoint = std.stWeakPoint;
            beStd.stFavoriteLesson = std.stFavoriteLesson;
            beStd.stHateLesson = std.stHateLesson;
            beStd.stUserName = std.stUserName;
            beStd.stPassWord = std.stPassWord;


            blStudent blstd = new blStudent();
            blstd.update(beStd);
            return View("showAll", blstd.read());
        }

        public void remove(int id) {
            blStudent std = new blStudent();
            std.remove(id);
            
            
        }
    }
}
