class StoredProcedureWithInput
{
	static void Main(string[] agrs)
	{
		try
		{
			string ConnectionString = "data source:., database=StudentDB;
			integrated security=SSPI;
			using(SqlConnection conn = new SqlConnection(ConnectionString)
			{
				SqlCommand cmd = new SqlCommand()
				{
					CommandText="student_id",
					Connection = conn,
					CommandType = CommandType.StoredProcedure
				};
				
				SqlParameter param1 = new SqlParameter
				{
					ParameterName = @ID",
					SqlDbType = SqlDbType.Int,
					value = 101,
					Direction = ParameterDirection.Input
				};
				
				cmd.Parameters.Add(param1);
				conn.Open();
				SqlDataReader sdr = cmd.ExecuteReader();
				while(sdr.Read())
				{
					Console.WriteLine(sdr["Id"]+", "+sdr["Name"]+", "+sdr["Email"]+", "+sdr["Mobile"]);
				}
			}
		}
		catch(Exception e)
		{
			Console.WriteLine("Oops, something went wrong."+e);
		}
		Console.ReadyKey();
	}
}