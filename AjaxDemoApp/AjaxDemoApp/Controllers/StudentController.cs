using AjaxDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemoApp.Controllers
{
    public class StudentController : Controller
    {
        StudentDBContext db = new StudentDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudent()
        {
            List<Student> studentList = db.Students.ToList<Student>();
            return Json(new { data = studentList }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create(int id = 0)
        {
            if (id == 0)
            {
                return View(new Student());
            }
            else
            {
                return View(db.Students.Where(x => x.StudenID == id).FirstOrDefault<Student>());
            }
        }

        [HttpPost]
        public ActionResult Create(Student std)
        {
            if (std.StudenID == 0)
            {
                db.Students.Add(std);
                db.SaveChanges();
                return Json(new { sucess = true, message = "Data saved successfully", JsonRequestBehavior.AllowGet });
            }
            else
            {
                db.Entry(std).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true, message = "Updated Successfully", JsonRequestBehavior.AllowGet });
            }
        }
    }
}