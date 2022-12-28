using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Implementing_Interface_and_Collection_DS
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("1. Add Car Details\n2. Display all Cars\n3. Delete Car\n4. Update Car details\n5. Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    CarsServiceImpl carsService = new CarsServiceImpl();
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=sanketdho-vd;Initial Catalog=crudDemo;Integrated Security=True");

                    switch (choice)
                    {
                        case 1:
                            int add = carsService.addCar();
                            if (add == 1)
                            {
                                Console.WriteLine("Car details Successfully added.\n");
                                sqlConnection.Close();
                            }
                            break;

                        case 2:
                            carsService.displayAllCars();
                            /*
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
                            */
                            break;

                        case 3:
                            try
                            {
                                Console.WriteLine("Enter the Car ID to Delete");
                                int id = Convert.ToInt32(Console.ReadLine());
                                int status = carsService.deleteById(id);

                                if (status == 0)
                                {
                                    Console.WriteLine("Car deletion done.\n");
                                }
                                else
                                {
                                    Console.WriteLine("ID does not exist or List is Empty.\n");
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                            break;

                        case 4:
                            try
                            {
                                Console.WriteLine("Enter the Car ID to update data");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Car Name");
                                string carName = Console.ReadLine();
                                int status = carsService.updateCar(id, carName);
                                if (status == 1)
                                {
                                    Console.WriteLine("Car Details Updated.\n");
                                }
                                else
                                {
                                    Console.WriteLine("ID does not exist or List is Empty.\n");
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;

                        case 5:
                            Console.WriteLine("Program terminated Successfully");
                            return;

                        default:
                            Console.WriteLine("Enter Correct choice.");
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
