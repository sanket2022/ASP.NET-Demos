using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
