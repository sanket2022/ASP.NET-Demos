using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class CustomerService : ICustomerService
    {
        public ICustomerRepository _iCustomerRepository;

        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }

        public List<Customer> GetCustomers()
        {
            return _iCustomerRepository.GetCustomers();
        }
    }
}
