using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    class CarsDaoImpl : CarsDao
    {
        //static List<Cars> clist;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=sanketdho-vd;Initial Catalog=crudDemo;Integrated Security=True");
        
        //static CarsDaoImpl()
        //{
        //    clist = new List<Cars>();
        //}

        // saving data directly to the database
        public int save(Cars cars)
        {
            sqlConnection.Open();
            string sqlQuery = "insert into cars(car_id, car_name, car_brand, car_color) values('" 
                + cars.CarId + "','"
                + cars.CarName + "','" 
                + cars.CarBrand + "','" 
                + cars.CarColor + "')";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            return cmd.ExecuteNonQuery();
            //clist.Add(cars);
        }

        //public List<Cars> findAll()
        //{
        //    return clist;
        //}

        
        public int removeById(int id)
        {
            //if(clist.Count!=0)
            //{
            //    for (int i = 0; i < clist.Count; i++)
            //    {
            //        if (clist[i].CarId == id)
            //        {
            //            return clist.Remove(clist[i]);
            //        }
            //    } 
            //}
            
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM cars WHERE car_id = '" + id + "'", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return 1;   
            }
            sqlConnection.Close();
            return 0;
        }

        public void findAllCars()
        {
            sqlConnection.Open();
            string query = "select * from cars";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Car Id \t  Car Name \t  Car Brand \t  Car Color");
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}", reader[0], reader[1], reader[2], reader[3]));
                }
                Console.WriteLine("\n");
            }
            sqlConnection.Close();
        }

        public int updateCar(int carId, string carName)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update cars set car_name='" + carName + "' where car_id= '" + carId + "'", sqlConnection);
            return cmd.ExecuteNonQuery();
        }
    }
}
