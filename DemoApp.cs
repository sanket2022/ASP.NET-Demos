using System;

public class DemoApp
{
	public DemoApp()

	{
		static void Main(string [] args)
        {
			Console.WriteLine("Find Square of The Number..!!!")
			Console.WriteLine("Enter Any Number :");
			int num = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Square of " + num + " is : " + num * num);
        }
	}
}
