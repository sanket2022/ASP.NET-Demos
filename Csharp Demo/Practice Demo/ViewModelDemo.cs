//Create separate files for each class

public class Employee
{
	public int EmployeeId{get; set;}
	public string Name{get; set;}
	public string Gender{get; set;}
	public string Department{get; set;}
	public decimal Salary{get; set;}
	public int AddressId{get; set;}
}

public class Address
{
	public int AddressId{get; set;}
	public string Country{get; set;}
	public string State{get;set;}
	public City{get; set;}
	public string Pin{get;set;}
}

public class EmployeeDetailsViewModel
{
	public Employee Employee{get;set;}
	public Address Address {get;set;}
	public string PageTitle{get; set;}
	public string PageHeader{get;set;}
}

//Controller:	to view data using ViewModel
public class EmployeeController : Controller
{
	public ViewResult Details()
	{
		Employee employee = new Employee()
		{
			Employee employee = new Employee()
			{
				EmployeeId = 101,
				Name = "Shubham",
				Gender = "Male",
				Department = "Development",
				Salary = 125000,
				AddressId = "Hinjewadi"
			};
			
			Address address = new Address()
			{
				AddressId = 1001,
				City = "Pune",
				State = "Pune",
				Country = "India",
				Pin = "410401"
			};
			
			EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
			{
				Employee = employee,
				Address = address,
				PageTitle = "Employee Details Page",
				PageHeader = "Employee Details"
			};
			
			return View(employeeDetailsViewModel);
		}
	}
}


// View Page
/*
@model FirstMVCDemo.ViewModels.EmployeeDetailsViewModel

@{ 
    Layout = null;
}
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>@Model.PageTitle</title>
</head>
<body>
    <h1>@Model.PageHeader</h1>
    <div>
        EmployeeID : @Model.Employee.EmployeeId
    </div>
    <div>
        Name : @Model.Employee.Name
    </div>
    <div>
        Gender : @Model.Employee.Gender
    </div>
    <div>
        Department : @Model.Employee.Department
    </div>
    <div>
        Salary : @Model.Employee.Salary
    </div>

    <h1>Employee Address</h1>
    <div>
        City : @Model.Address.City
    </div>
    <div>
        State : @Model.Address.State
    </div>
    <div>
        Country : @Model.Address.Country
    </div>
    <div>
        Pin : @Model.Address.Pin
    </div>
</body>
</html>
*/