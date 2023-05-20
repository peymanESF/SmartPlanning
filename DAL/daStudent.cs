using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BE;

namespace DAL
{
    public class daStudent
    {
        public void create(student std)
        {
            db db = new db();
            db.Students.Add(std);
            db.SaveChanges();
        }
        public List<student> read()
        {
            db db = new db();
            return db.Students.ToList();
        }
        public List<student> search(string tag)
        {
            List<student> stdRes = new List<student>();
            

                db db1 = new db();
                if (float.TryParse(tag, out float f))
                {
                var fRes = from i in db1.Students
                           where i.stAverage == f || i.id == f 
                               select i;
                    stdRes = stdRes.Concat(fRes.ToList()).ToList();
                }
               

                    var q = from i in db1.Students
                            where i.stName.Contains(tag.ToString()) || i.stFamily.Contains(tag.ToString()) || i.stPaye.Contains(tag.ToString())
                            select i;

            stdRes = stdRes.Concat(q.ToList()).ToList();




            return stdRes;
        }
        public int login(string username, string password)
        {
            db db = new db();
            var q = from i in db.Students
                    where i.stUserName.Equals(username) && i.stPassWord.Equals(password)
                    select i;
            student std = new student();
            
            if (q.Any() == true)
            {
                std = q.Single();
                return std.id;
            }
            return 0;
        }
        public student show(int id)
        {
            db db1 = new db();
            var q = from i in db1.Students where i.id == id select i;
            return q.Single();
        }

        public void update(student std)
        {
            db db1 = new db();
            var q = from i in db1.Students where i.id == std.id select i;
            student sNew = new student();
            sNew = q.Single();
            sNew.email = std.email;
            sNew.gender = std.gender;
            sNew.stAddress = std.stAddress;
            sNew.stAverage = std.stAverage;
            sNew.stClassNum = std.stClassNum;
            sNew.stFamily = std.stFamily;
            sNew.stFatherNum = std.stFatherNum;
            sNew.stFavoriteLesson = std.stFavoriteLesson;
            sNew.stHateLesson = std.stHateLesson;
            sNew.stMotherNum = std.stMotherNum;
            sNew.stName = std.stName;
            sNew.stPassWord = std.stPassWord;
            sNew.stPaye = std.stPaye;
            sNew.stPhoneNumber = std.stPhoneNumber;
            sNew.stPic = std.stPic;
            sNew.stStrengthsPoint = std.stStrengthsPoint;
            sNew.stTel = std.stTel;
            sNew.stUserName = std.stUserName;
            sNew.stWeakPoint = std.stWeakPoint;
            db1.SaveChanges();

        }

        public void remove(int id)
        {
            db db = new db();
            var q = from i in db.Students where i.id == id select i;
            db.Students.Remove(q.Single());
            db.SaveChanges();

        }
    }
}
