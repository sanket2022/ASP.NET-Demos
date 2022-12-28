// stored procedure
/*
CREATE TABLE Accounts
(
	AccountNumber VARCHAR(60) PRIMARY KEY,
	CustomerName VARCHAR(60),
	Balance int
);
GO

INSERT INTO Accounts VALUES('Account1','James',1000);
INSERT INTO Accounts VALUES('Account2','Smith',2000);
GO
*/

using(SqlConnection conn = new SqlConnection(ConnectionString))
{
	conn.Open();
	
	SqlTransaction transaction = conn.BeginTransaction();
	
	try
	{
		SqlCommand cmd = new SqlCommand("UPDATE Accounts SET Balance = Balance - 500 WHERE AccountNumber='Account1',conn, transaction);
		cmd.ExecuteNonQuery();
		
		cmd = new SqlCommand("UPDATE Acoounts SET Balance = Balance + 500 WHERE AccountNumber='Account1',conn, transaction);
		cmd.ExecuteNonQuery();
		
		transaction.Commit();
		Console.WriteLine("Transaction Commited");
	}
	catch
	{
		transaction.RollBack();
		Console.WriteLine("Transaction RollBack");
	}
}