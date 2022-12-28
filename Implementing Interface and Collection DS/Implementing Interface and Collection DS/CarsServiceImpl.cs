using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int addCar()
        {
            try
            {
                Console.WriteLine("Enter Car Name");
                string carName = Console.ReadLine();
                Console.WriteLine("Enter Car Color");
                string carColor = Console.ReadLine();
                Console.WriteLine("Enter Car Brand");
                string carBrand = Console.ReadLine();
                Console.WriteLine("Enter Car ID");
                int carId = Convert.ToInt32(Console.ReadLine());
                return carsDao.save(new Cars(carName, carColor, carBrand, carId));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }   
        }

        //public List<Cars> displayAll()
        //{
        //    return carsDao.findAll();
        //}

        public int deleteById(int id)
        {
            return carsDao.removeById(id);
        }

        public void displayAllCars()
        {
            carsDao.findAllCars();
        }

        public int updateCar(int carId, string carName)
        {
            return carsDao.updateCar(carId, carName);
        }
    }
}
