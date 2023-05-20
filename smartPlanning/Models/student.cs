using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace smartPlanning.Models
{
    public class student
    {

        public int id { get; set; }



        public string stName { get; set; }

        public string stFamily { get; set; }

        public string gender { get; set; }

        public string email { get; set; }

        public HttpPostedFileBase stPic { get; set; }

        public string stPaye { get; set; }

        public float stAverage { get; set; }

        public int stClassNum { get; set; }

        public string stPhoneNumber { get; set; }

        public string stTel { get; set; }

        public string stFatherNum { get; set; }
        public string stMotherNum { get; set; }

        public string stAddress { get; set; }


        public string stStrengthsPoint { get; set; }
        public string stWeakPoint { get; set; }

        public string stFavoriteLesson { get; set; }

        public string stHateLesson { get; set; }

        //public medicalInformation stMedical { get; set; }

        //public tests stTest { get; set; }

        //public consultTime stConsultTime { get; set; }

        //public FourChoiceExam stTestExam { get; set; }

        //public monthlyExam stMonthlyExam { get; set; }

        //public planning stPlan { get; set; }

        public string stUserName { get; set; }

        public string stPassWord { get; set; }

    }
}