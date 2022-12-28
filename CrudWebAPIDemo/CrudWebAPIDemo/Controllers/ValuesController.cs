using CrudWebAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudWebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/Values/InsertCustomer")]
        [HttpPost]
        public Customer InsertCustomer(Customer _customer)
        {
            using(CustomerEntities entities  = new CustomerEntities())
            {
                entities.Customers.Add(_customer);
                entities.SaveChanges();
            }
            return _customer;
        }

        [Route("api/Values/UpdateCustomer")]
        [HttpPost]
        public bool UpdateCustomer(Customer _customer)
        {
            using(CustomerEntities entities = new CustomerEntities())
            {
                Customer updateCustomer = (from c in entities.Customers
                                           where c.CustomerId == _customer.CustomerId
                                           select c).FirstOrDefault();
                updateCustomer.Name = _customer.Name;
                updateCustomer.Country = _customer.Country;
                entities.SaveChanges();
            }
            return true;
        }

        [Route("api/Values/DeleteCustomer")]
        [HttpPost]
        public void DeleteCustomer(Customer _customer)
        {
            using(CustomerEntities entities = new CustomerEntities())
            {
                Customer customer = (from c in entities.Customers
                                     where c.CustomerId == _customer.CustomerId
                                     select c).FirstOrDefault();
                entities.Customers.Remove(customer);
                entities.SaveChanges();
            }
        }
    }
}
