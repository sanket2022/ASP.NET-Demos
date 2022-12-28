using MVCCrudOperations.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MVCCrudOperations.Controllers
{
    public class HomeController : Controller
    {
        CrudDemoEntities _context = new CrudDemoEntities();
        public ActionResult Index()
        {
            var listofData = _context.Employees.ToList();
            return View(listofData);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee model)
        {
            _context.Employees.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data Submitted Successfully";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Employee Model)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == Model.EmployeeId).FirstOrDefault();
            if(data!=null)
            {
                data.EmployeeCity = Model.EmployeeCity;
                data.EmployeeName = Model.EmployeeName;
                data.EmployeeSalary = Model.EmployeeSalary;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            _context.Employees.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record Deletion Successful.";
            return RedirectToAction("Index");
        }
    }
}