using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class blStudent
    {
        public void create(student std)
        {
            daStudent daStudent = new daStudent();
            daStudent.create(std);

        }
        public List<student> read()
        {
            daStudent dastd = new daStudent();
            return dastd.read();
        }
        public List<student> search(string tag)
        {
            daStudent daStd = new daStudent();
            return daStd.search(tag);
        }
        public int login(string username,string password)
        {
            daStudent dastd = new daStudent();
            return dastd.login(username, password);
        }
        public student show(int id)
        {
            daStudent dastd = new daStudent();
            return dastd.show(id);
        }

        public void update(student std)
        {
            daStudent daStudent = new daStudent();
            daStudent.update(std);

        }
        public void remove(int id)
        {
            daStudent std = new daStudent();
            std.remove(id);
        }
    }
}
