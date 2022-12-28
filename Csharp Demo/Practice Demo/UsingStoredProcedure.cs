/*
CREATE DATABSE StudentDB;
GO

USE StudentDB;
GO

CREATE TABLE Student(
[Id] [int] IDENTITY(100,1) PRIMARY KEY,
[Name] [varchar](100) NULL,
[Email] [varchar](50) NULL,
[Mobile] [varchar](50) NULL,
)
GO
INSERT INTO Student VALUES('Sanket','sanketdho@cybage.com','8665942652');
INSERT INTO Student VALUES('Hardik','hardik@cybage.com,'8588596895');
*/

// creating stored procedure
/*
CREATE PROCEDURE spGetStudents
AS
BEGIN
	SELECT Id, Name, Email, Mobile
FROM student
END
*/

class UsingStoredProcedure
{
	static void Main(string[]args)
	{
		try
		{
			string ConnectionString = "data source:.; database=StudentDB;
			integrated security=SSPI";
			using(SqlConnection conn = new SqlConnection(ConnectionString)
			{
				SqlCommand cmd = new SqlCommand("spGetStudents", conn)
				{
					CommandType = CommandType.StoredProcedure
				};
				conn.Open();
				SqlDataAdapter sdr = cmd.ExecuteReader();
				while(sdr.Read())
				{
					Console.WriteLine(sdr["Id"]+", "+sdr["Name"]+", "+sdr["Mobile"]);
				}
			}
		}
		catch(Exception e)
		{
			Console.WriteLine("Oops, something went wrong\n."+e);
		}
		Console.ReadKey();
	}
}

// Stored Procedure with INPUT
/*
CREATE PROCEDURE spGetStudentById
(
	@Id INT
)
AS
BEGIN
	SELECT Id, Name, Email, Mobile
	FROM Student
	WHERE Id = @Id
END
*/

//How to call a stored procedure with an input parameter in c# ADO.NET
/*
SqlCommand cmd = new SqlCommand()
{
	commandText = "spGetStudentById",
	Connection = conn,
	CommandType = CommandType.StoredProcedure
};

//set Sqpparameter
SqlParameter param1 = new SqpParameter
{
	ParamneterName = "@Id",
	SqlDbType = SqlDbType.Int,
	Value = 101,
	Direction = ParamterDirection.Input
};

cmd.Parameters.Add(param1);

conn.Open();
SqlDataReader sdr = cmd.ExecuteReader();
while(sdr.Read())
{
	Console.WriteLine(sdr["id"]+", "+sdr["Name"]+", "+sdr["Email"]+", "+sdr["Mobile"]);
}

cmd.Paramters.Add(param1);
*/

//How to call a stored procedure with both input and output paramters in c#
/*
SqlParameter outParameter = new Sqlparameter
{
	ParameterName  = "@Id",
	SqlDbType = SqlDbType.Int,
	Direction = ParameterDirection.Output
};

cmd.Parameters.Add(outParameter); 
conn.Open();
cmd.ExecutenonQuery();

Console.writeLine("Newly generated student ID: "+outParameter.Value.ToString());
*/