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
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Student model = new Student();
            model.studentClasses = ClassService.Instance.Get();
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin User")]
        public ActionResult Create(Student student)
        {
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