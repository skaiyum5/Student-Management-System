using HsMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HsMS.Database
{
    public class StudentService
    {

        #region singleTon
        public static StudentService Instance
        {
            get
            {
                if (instance == null) instance = new StudentService();
                {
                    return instance;
                }

            }
        }
        private static StudentService instance { get; set; }
        public StudentService()
        {

        }
        #endregion 

        public List<Student> Get()
        {
            HsMSDBContext context = new HsMSDBContext();
            return context.Students.Include("StudentClass").ToList();
        }
        public bool Create(Student student)
        {
            using (HsMSDBContext context = new HsMSDBContext())
            {
                context.Students.Add(student);
                return context.SaveChanges() > 0;
            }
        }
        
    }
}
