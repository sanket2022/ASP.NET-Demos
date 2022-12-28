using CustomiseExceptionFilter.Models;
using System.Web;
using System.Web.Mvc;

namespace CustomiseExceptionFilter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogCustomExceptionFilter());
        }
    }
}
