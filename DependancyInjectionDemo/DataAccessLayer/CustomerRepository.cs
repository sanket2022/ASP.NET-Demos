using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers() {
            return new List<Customer>
            {
                new Customer{CustomerId = 1, City="Mumbai",CustomerName="Rudra"},
                new Customer{CustomerId = 2, City="Pune",CustomerName="Sanket"},
                new Customer{CustomerId = 3, City="Shrirampur",CustomerName="Aniket"},
                new Customer{CustomerId = 4, City="Shrirampur",CustomerName="Prasad"}
            }; 
        }
    }
}
