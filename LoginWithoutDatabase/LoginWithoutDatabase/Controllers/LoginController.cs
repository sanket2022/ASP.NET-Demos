using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginWithoutDatabase.Models;

namespace LoginWithoutDatabase.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{Id=1,UserName="sanket",Password="sanket123"},
                new UserModel{Id=1,UserName="shubham",Password="@123456"},
                new UserModel{Id=1,UserName="milan",Password="milan@22"},
                new UserModel{Id=1,UserName="tejas",Password="tejas121"}
            };
            return users;
        }

        [HttpPost]
        public ActionResult Verify(UserModel user)
        {
            var users = PutValue();

            var userId = users.Where(u => u.UserName.Equals(user.UserName));

            var userPassword = users.Where(u => u.Password.Equals(user.Password));

            if(userPassword.Count() == 1)
            {
                ViewBag.message = "Login Successful.";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }

        }
    }
}