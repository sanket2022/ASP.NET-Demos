using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    interface CarsDao
    {
        public void save(Cars cars);

        public List<Cars> findAll();

        public bool removeById(int id);
    }
}

