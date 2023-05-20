using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;
using System.Configuration;

namespace DAL
{
    class db :DbContext
    {
        public db() : base("name=constrMain") { }
        public DbSet<student> Students { set; get; }
    }
}
