using CrudWebAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudWebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            CustomerEntities entities = new CustomerEntities();
            List<Customer> customers = entities.Customers.ToList();
            if(customers.Count == 0)
            {
                customers.Add(new Customer());
            }
            return View(customers);
        }
    }
}
