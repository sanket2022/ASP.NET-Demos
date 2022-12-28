//we have added data into TempData ans Acceessed the same data using a key inside
//another action method.

public class EmployeeController : Controller
{
	public ActionResult Method1()
	{
		TempData["Name"] = "Rudra";
		TempData["Age"]=30;
		return View();
	}
	
	public ActionResult Method2()
	{
		string Name;
		int Age;
		
		if(TempData.ContainsKey("Name"))
			Name = TempData["Name"].ToString();
		
		if(TempData.ContainsKey("Name"))
			Age = int.Parse(TempData["Age"].ToString());
		
		return View();
	}
	
	public ActionResult Method3()
	{
		string Name;
		int Age;
		
		if(TempData.ContainsKey("Name"))
			Name = TempData["Name"].ToString();
		
		if(TempData.ContainsKey("Age"))
			Age =int.Parse(TempData["Age"].ToString());
		
		return View();
	}
}

//Retaining TempData values in the third consecutive request
public class EmployeeController : Controller
{
	public ActionResult Method1()
	{
		TempData["Name"] = "Tengu";
		TempData["Age"] = 3;
		return View();
	}
	
	public ActionResult Mathod2()
	{
		string Name;
		int Age;
		
		if(TempData.ContainsKey("Name"))
			Name = TempData["Name"].ToString();
		
		if(TempData.ContainsKey("Age"))
			Age = int.Parse(TempData["Age"].ToString());
		
		TempData.Keep();
		
		return View();
	}
	
	public ActionResult Method3()
	{
		string Name;
		int Age;
		 if(TempData.ContainsKey("Name"))
			 Name= = TempData["Name"].ToString();
		 
		 if(TempData.ContainsKey("Age"))
			 Age = int.Parse(TempData["Age"].ToString());
		 
		 return View();
	}
}