public class RouteConfig
{
	public static void RegisterRoutes(RouteCollection routes)
	{
		routes.MapRoute(
			name:"Employee",
			url:"Employuee/{id}",
			defaults:new{ controller = "Employee", action = "Index"}
		);
		
		routes.MapRoute(
			name:"Default", //Route Name
			url:"{controller}/{action}/{id}", // Route Pattern
			defaults:new
			{
				controller = "Home", //Controller Name
				action = "Index", //Action method Name
				id = UrlParameter.Optional //Default value for above defined parameter
			}
		);
	}
}
