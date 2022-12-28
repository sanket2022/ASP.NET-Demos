using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeLogin.Models
{
    public class EmployeeModel
    {
        public int employeeId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}