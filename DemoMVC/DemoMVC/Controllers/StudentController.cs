using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details(int studentId)
        {
            StudentBusinessLayer studentBL = new StudentBusinessLayer();
            Student studentDetail = studentBL.GetById(studentId);
            return View(studentDetail);
        }
    }
}