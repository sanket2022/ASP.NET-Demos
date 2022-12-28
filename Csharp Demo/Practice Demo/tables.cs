class TableDemo
{
	try
	{
	// Creating table in c#
		DataTable Orders = new DataTables("Orders");

		DataColumn OrderId = new DataColumn("ID", typeof(Int32));
		Orders.Columns.Add(OrderId);
		DataColumn CustId = mew DataColumn("CustomerId", typeof(Int32));
		Orders.Columns.Add(CustId);
		DataColumn OrderAmount = new DataColumn("Amount", typeof(Int32));
		Orders.Columns.Add(OrderAmount);

		Orders.Rows.Add(10001,101,25000);
		orders.Rows.Add(20002,202,50000);


		// Creating dataset object
		DataSet dataset = new DataSet();

		dataset.Tables.Add(Orders);

		//Fetching datatable from dataset using the Index position
		freach(DataRow row in dataSet.Tables[0].Rows)
		{
			Console.WriteLine(row["ID"]+", "+row["Name"]+", "+row["Email"]);
		}
	}
	catch(Exception e)
	{
		Console.WriteLine("oops, something went wrong.\n" + e);
	}
	Console.ReadKey();
}


