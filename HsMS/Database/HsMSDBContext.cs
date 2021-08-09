using HsMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HsMS.Database
{
    public class HsMSDBContext : DbContext
    {
        public HsMSDBContext() : base("name= HsMSConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
    }
}