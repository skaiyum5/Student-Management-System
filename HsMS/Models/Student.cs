using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HsMS.Models
{
    public class Student:BaseEntity
    {
        public string Address { get; set; }
        public string AdmissionDate { get; set; }
        public virtual StudentClass StudentClass { get; set; }
        public Student()
        {
            StudentClass = new StudentClass();
        }
    }
}
