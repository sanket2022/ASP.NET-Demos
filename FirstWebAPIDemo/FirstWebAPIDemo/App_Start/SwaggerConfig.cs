using System.Web.Http;
using WebActivatorEx;
using FirstWebAPIDemo;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace FirstWebAPIDemo
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "First Web API Demo");
                    c.IncludeXmlComments(string.Format(@"{0}/bin/FirstWebAPIDemo.XML",
                        System.AppDomain.CurrentDomain.BaseDirectory));
                })
                .EnableSwaggerUi();
        }
    }
}