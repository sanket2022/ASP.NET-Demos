using System;


namespace Implementing_Interface_and_Collection_DS
{
    class Cars
    {
        private string carName;
        private string carColor;
        private string carBrand;
        private int carId;

        public Cars(string carName, string carColor, string carBrand, int carId)
        {
            this.carName = carName;
            this.carColor = carColor;
            this.carBrand = carBrand;
            this.carId = carId;
        }

        public string CarName 
        {
            get { return carName; }
            set { carName = value; }
        }

        public string CarColor
        {
            get { return carColor; }
            set { carColor = value; }
        }

        public string CarBrand
        {
            get { return carBrand; }
            set { carBrand = value; }
        }

        public int CarId
        {
            get { return carId; }
            set { carId = value; }
        }

        public override string ToString()
        {
            Console.WriteLine("**************************");
            return "Car: "+this.carName+",\nColor: "+this.carColor+",\nBrand: "+this.carBrand+",\nCar-ID: "+this.carId;
        }

    }
}
