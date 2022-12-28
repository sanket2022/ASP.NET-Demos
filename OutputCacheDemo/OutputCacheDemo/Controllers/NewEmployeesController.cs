using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OutputCacheDemo.DAL;

namespace OutputCacheDemo.Controllers
{
    public class NewEmployeesController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: NewEmployees
        //[OutputCache(Duration =10)]
        public ActionResult Index()
        {
            //System.Threading.Thread.Sleep(3000);
            //return View(db.NewEmployees.ToList());
            return View(db.NewEmployees.ToList());
        }


        [ChildActionOnly]
        [OutputCache(Duration =10)]
        public string GetEmployeeCount()
        {
            return "Employee Count = " + db.NewEmployees.Count().ToString() + "@ "
                + DateTime.Now.ToString();
        }

        // GET: NewEmployees/Details/5
        [OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewEmployee newEmployee = db.NewEmployees.Find(id);
            if (newEmployee == null)
            {
                return HttpNotFound();
            }
            return View(newEmployee);
        }

        // GET: NewEmployees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Gender,Email,Salary")] NewEmployee newEmployee)
        {
            if (ModelState.IsValid)
            {
                db.NewEmployees.Add(newEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newEmployee);
        }

        // GET: NewEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewEmployee newEmployee = db.NewEmployees.Find(id);
            if (newEmployee == null)
            {
                return HttpNotFound();
            }
            return View(newEmployee);
        }

        // POST: NewEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Gender,Email,Salary")] NewEmployee newEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newEmployee);
        }

        // GET: NewEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewEmployee newEmployee = db.NewEmployees.Find(id);
            if (newEmployee == null)
            {
                return HttpNotFound();
            }
            return View(newEmployee);
        }

        // POST: NewEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewEmployee newEmployee = db.NewEmployees.Find(id);
            db.NewEmployees.Remove(newEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
