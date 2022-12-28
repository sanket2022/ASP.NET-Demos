using System;
using System.Collections.Generic;
using System.Text;

namespace Implementing_Interface_and_Collection_DS
{
    class CarsServiceImpl: CarsService
    {
        private CarsDaoImpl carsDao;

        public CarsServiceImpl()
        {
            carsDao = new CarsDaoImpl();
        }

        public void addCar()
        {
            Console.WriteLine("Enter Car Name");
            string carName = Console.ReadLine();
            Console.WriteLine("Enter Car Color");
            string carColor = Console.ReadLine();
            Console.WriteLine("Enter Car Brand");
            string carBrand = Console.ReadLine();
            Console.WriteLine("Enter Car ID");
            int carId = Convert.ToInt32(Console.ReadLine());
            carsDao.save(new Cars(carName, carColor, carBrand, carId));
        }

        public List<Cars> displayAll()
        {
            return carsDao.findAll();
        }

        public bool deleteById(int id)
        {
            return carsDao.removeById(id);
        }
    }
}
