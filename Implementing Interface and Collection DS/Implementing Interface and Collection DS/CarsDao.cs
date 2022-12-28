using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    interface CarsDao
    {
        public int save(Cars cars);

        //public List<Cars> findAll();

        public int removeById(int id);

        public void findAllCars();

        public int updateCar(int carId, string carName);
    }
}

