using System;
using System.Collections.Generic;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    interface CarsService
    {
        public void addCar();

        public List<Cars> displayAll();

        public bool deleteById(int id);
    }
}
