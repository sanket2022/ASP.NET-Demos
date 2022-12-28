using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomiseExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }

        public ActionResult About()
        {
            throw new NullReferenceException();
        }

        public ActionResult Contact()
        {
            throw new DivideByZeroException();
        }
    }
}