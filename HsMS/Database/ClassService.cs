using HsMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HsMS.Database
{
    public class ClassService
    {
        #region singleTon
        public static ClassService Instance
        {
            get
            {
                if (instance == null) instance = new ClassService();
                {
                    return instance;
                }

            }
        }
        private static ClassService instance { get; set; }
        public ClassService()
        {

        }
        #endregion

        public List<StudentClass> Get()
            {
                HsMSDBContext context = new HsMSDBContext();
                return context.StudentClasses.ToList();
            } public StudentClass Get(int id)
            {
                HsMSDBContext context = new HsMSDBContext();
                return context.StudentClasses.FirstOrDefault(x=>x.Id==id);
            }
            public bool Create(StudentClass StudentClass)
            {
                using (HsMSDBContext context = new HsMSDBContext())
                {
                    context.StudentClasses.Add(StudentClass);
                    return context.SaveChanges() > 0;
                }
            }

        
    }
}
