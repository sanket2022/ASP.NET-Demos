using EmployeeLogin.Models;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace EmployeeLogin.Controllers
{
    public class EmployeeController : Controller
    {
        
        
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Employee
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source=SANKETDHO-VD; database=MVCDemo; integrated security=SSPI;";
        }
        public ActionResult Verify(EmployeeModel emp)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from employee where username = '"+emp.username+"' and password = '"+emp.password+"'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return View("Login");
            }
            else
            {
                con.Close();
                return View("Error");
            }            
        }
    }
}