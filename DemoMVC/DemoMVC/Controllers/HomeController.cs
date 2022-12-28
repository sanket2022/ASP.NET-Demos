using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(101);

            //Stronly typed
            ViewBag.Header = "Employee Details";

            return View(employee);

            //ViewData 
            /*
            ViewData["Employee"] = employee;
            ViewData["Header"] = "Employee Details";
            */

            //ViewBag
            /*
            ViewBag.Employee = employee;
            ViewBag.Header = "Employee Details";
            */


        }
    }
}