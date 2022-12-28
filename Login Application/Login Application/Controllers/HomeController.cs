using Login_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Application.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBContext db = new EmployeeDBContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            var emp = db.Employees.Where(x => x.Email == employee.Email
                        && x.Password == employee.Password).Count();

            if(emp > 0)
            {
                //Console.WriteLine("Wrong Email or Password");
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            } 
        }

        public ActionResult Dashboard(string v)
        {
            return View();
        }

        public ActionResult Registration(int id = 0)
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult Registration(Employee emp)
        {
            using(EmployeeDBContext db = new EmployeeDBContext())
            {
                db.Employees.Add(emp);
                db.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Registration", new Employee());
        }
    }
}