using HsMS.Database;
using HsMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HsMS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> students = StudentService.Instance.Get();
            return View(students);
        }
        [HttpGet]
        public ActionResult Create()
        {
            StudentViewModel model = new StudentViewModel();
            model.StudentClasses = ClassService.Instance.Get();
            return View(model);
        }
        [HttpPost]
        //[Authorize(Roles = "Admin User")]
        public ActionResult Create(StudentViewModel model)
        {
            Student student = new Student();
            student.Name = model.Name;
            student.Address = model.Address;
            student.AdmissionDate = model.AdmissionDate;
            student.StudentClass = ClassService.Instance.Get(model.ClassId);
           bool result = StudentService.Instance.Create(student);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
