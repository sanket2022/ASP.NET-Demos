class Program
{
	static void Main(string [] agrs)
	{
		try
		{
			string ConString = "data source=.; database=StidentDB; integrated security=SSPI";
			using(SqlConnection conn = new SqlConnection(conn))
			{
				SqlCommand cm = new SqlCommand("select * from Student", conn);
				conn.open();
				SqlDataReAader sdr = cm.ExecuteReader();
				while(sdr.Read())
				{
					Console.WriteLine(sdr["Name"]+", "+sdr["Email"]+", "+sdr["Mobile"]);
				}
			}
		}
		catch(Exception e)
		{
			Console.WriteLine("OOPs, something went wrong..!!!");
		}
		Console.ReadKey();
	}
}