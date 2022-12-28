class DatatableDemo
{
	static void Main(string[]agrs)
	{
		try
		{
			//creating data table instace
			Datatable datatable = new Datatable("Student");
			
			//add the datacolumn using all properties
			DataColumn Id = new DataColumn("ID");
			Id.DataType = typeof(int);
			Id.Unique = true;
			Id.AllowDBNull = false;
			Id.Caption = "Student ID";
			dataTable.Columns.Add(Id);
			
			//add the Datacolun few properties
			DataColumn Name = new DataColumn("Name");
			Name.MaxLength = ;
			Name.AllowDBNull = false;
			dataTable.Columns.Add(Name);
			
			//add the datacolumn using defaults
			DataColumn Email = new DataColumn("Email");
			dataTable.Columns.Add(Email);
			
			//setting the primary key
			dataTable.PrimaryKey = new DataColumn[]{Id};
			
			//Add New DataRow by creating the DataRow object
			DataRow row1 = dataTable.NewRow();
			row1["Id"] = 101;
			row1["Name"] = "Anurag";
			row1["Email"] = "Anurag@dotnettutorials.net";
			dataTable.Rows.Add(row1);
			
			// Adding new DataRow by simply adding the values
			dataTable.Rows.Add(102,"Mohanty", "Mohanty@dotnettutorials.net");
			
			foreach(DataRow row in dataTable.Rows)
			{
				Console.writeLine(row["Id"] + ", " + row["Name"] + ", " + row["Email"]);
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("Oops, something went wrong.\n" + e);
		}
		Console.ReadKey();
	}
// }