using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Rudra",
                Gender = "Male",
                City = "Mumbai",
                Salary = 1000,
                Address = "Mulund East"
            };
            return employee;
        }
    }
}