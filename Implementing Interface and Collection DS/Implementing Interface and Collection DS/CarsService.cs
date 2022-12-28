using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    interface CarsService
    {
        public int addCar();

        //public List<Cars> displayAll();

        public int deleteById(int id);

        public void displayAllCars();

        public int updateCar(int carId, string carName);
    }
}
