using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace smartPlanning.Models
{
    public class db : DbContext
    {
        public db() : base("name=constrMain") { }

        public DbSet<student> students;

    }
}