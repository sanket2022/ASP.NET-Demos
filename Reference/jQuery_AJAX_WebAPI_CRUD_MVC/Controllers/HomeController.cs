﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_AJAX_WebAPI_CRUD_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CustomersEntities entities = new CustomersEntities();
            List<Customer> customers = entities.Customers.ToList();
            if (customers.Count == 0)
            {
                customers.Add(new Customer());
            }

            return View(customers);
        }
    }
}