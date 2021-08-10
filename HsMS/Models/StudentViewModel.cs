using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HsMS.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AdmissionDate { get; set; }
        public int ClassId { get; set; }
        public List<StudentClass> StudentClasses { get; set; }
        public StudentViewModel()
        {
            StudentClasses = new List<StudentClass>();
        }
    }
}