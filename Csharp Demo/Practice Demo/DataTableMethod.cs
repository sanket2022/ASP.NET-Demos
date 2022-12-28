class DataTableMethod
{
	try
	{
		string ConnectionString = "data source =.; database=studentDB; integrated
		security = SSPI";
		using(SqlConnection conn = new SqlConnection(ConnectionString))
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from student",conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			
			foreach(DataRow row in dt.Rows)
			{
				Console.WriteLine(row["Name"] + ", " + row["Email"] + ", " + row["Mobile"]);
			}
		}
	}
	catch(Exception e)
	{
		Console.WriteLine("Oops, somthing went wrong.\n" + e);
	}
	Console.ReadKey();
}

//Procedure to write in SSMS tool
/*
CREATE DATABASE StudentDB;
GO

USE StudentDB;
Go

CREATE TABLE Student(
Id INT PRIMARY KEY,
Name VARCHAR(100),
Email VARCHAR(50),
Mobile VARCHAR(50)
)
GO


INSERT INTO Student VALUES (101, 'Anurag', 'Anurag@dontnettutorials.net','1234567890');
INSERT INTO Student VALUES (102, 'Priyanka','Priyanka@dotnettutorials.net','6655223311');
GO
*/