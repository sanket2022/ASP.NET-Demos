using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    class CarsDaoImpl : CarsDao
    {
        static List<Cars> clist;

        string insertQuery = "insert into cars(car_id, car_name, car_brand, car_color) values()";

        static CarsDaoImpl()
        {
            clist = new List<Cars>();
        }

        public void save(Cars cars)
        {
            clist.Add(cars);
        }

        public List<Cars> findAll()
        {
            return clist;
        }

        public bool removeById(int id)
        {
            if(clist.Count!=0)
            {
                for (int i = 0; i < clist.Count; i++)
                {
                    if (clist[i].CarId == id)
                    {
                        return clist.Remove(clist[i]);
                    }
                } 
            }
            /*
            else
            {
                Console.WriteLine("List is Empty");
            }*/
            return false;

        }
    }
}
