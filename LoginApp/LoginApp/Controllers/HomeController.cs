using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class HomeController : Controller
    {

        LoginEntities db = new LoginEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(employee emp)
        {
            var employee = db.employees.Where(x => x.username == emp.username && x.password == emp.password).Count();
            if (employee > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Index");
            }
        }

        
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Registration(int id = 0)
        {
            employee emp = new employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult Registration(employee emp)
        {
            using (LoginEntities db = new LoginEntities())
            {
                db.employees.Add(emp);
                db.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Registration", new employee());
        }

    }
}