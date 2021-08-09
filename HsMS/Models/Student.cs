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
        public int ClassId { get; set; }
        public List<StudentClass> studentClasses { get; set; }
        public Student()
        {
            studentClasses = new List<StudentClass>();
        }
    }
}