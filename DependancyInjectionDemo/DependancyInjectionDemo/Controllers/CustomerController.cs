using System.Web.Mvc;
using System.Runtime.Remoting.Services;

namespace DependancyInjectionDemo.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        public ActionResult Index()
        {
            return Json(_iCustomerService.GetCustomers(), JsonRequestBehavior.AllowGet);
        }


    }
}