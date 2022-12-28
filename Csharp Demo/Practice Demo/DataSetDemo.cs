class DataSetDemo
{
	ststic void Main(string [] agrs)
	{
		try
		{
			string ConnectionString = "data source=.; database=ShoppingCartDB;
			integrated security=SSPI;
			using(SqlConnection conn = new SqlConnection(ConnectionString)
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from customers; select * from orders", conn);
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				
				//First table
				Console.WriteLine("Table 1 Data");
				foreach(DataRow row in dataSet.Tables[0].Rows)
				{
					Console.WriteLine(row["Id"]+", "+row["Name"]+", "+row["Mobile"]);
				}
				Console.WriteLine();
				
				// Seciond Table
				Console.WriteLine("Table 2 Data");
				foreach(DataRow row in dataSet.Tables[1].Rows)
				{
					Console.WriteLine(row["Id"]+", "+row["CustomerId"]+", "+row["Amount"]);
				}
				/*
				Here we can use either index or name of the table directly
				ex. dataSet.Tables[0].Rows or
					dataSet.Tables[1].Rows
				*/
			}
			Console.ReadKey();
		}
	}catch(Exception e)
	{
		Console.WriteLine("Oops, something went wrong\n"+e);
	}
	Console.readKey();
}