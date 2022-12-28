using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Implementing_Interface_and_Collection_DS
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=sanketdho-vd;Initial Catalog=crudDemo;Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection established Successfully.");

                while (true)
                {
                    Console.WriteLine("1. Add Car Details\n2. Display all Cars\n3. Delete Car\n4. Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    CarsServiceImpl carsService = new CarsServiceImpl();

                    switch (choice)
                    {
                        case 1:
                            carsService.addCar();
                            break;

                        case 2:
                            List<Cars> clist = carsService.displayAll();
                            if (clist.Count == 0)
                            {
                                Console.WriteLine("No Car Available");
                            }
                            else
                            {
                                foreach (Cars car in clist)
                                {
                                    Console.WriteLine(car);
                                }
                                Console.WriteLine("**************************");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter the Car ID to Delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            bool status = carsService.deleteById(id);
                            if(status)
                            {
                                Console.WriteLine("Car deletion done.");
                            }
                            else
                            {
                                Console.WriteLine("ID does not exist or List is Empty");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Program terminated Successfully");
                            return;

                        default:
                            Console.WriteLine("Enter Correct choice.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
