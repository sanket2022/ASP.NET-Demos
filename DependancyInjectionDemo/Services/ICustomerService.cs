using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
