using System;

namespace Generics
{
    class LightCar : ICar
    {
        private readonly string carName;
        private readonly DateTime carYear;
        private readonly int carPassengers;

        public string CarName { get { return carName; } }
        public DateTime CarYear { get { return carYear; } }
        public int CarPassengers { get { return carPassengers; } }

        public LightCar(string carName, DateTime carYear, int carPassengers)
        {
            this.carName = carName;
            this.carYear = carYear;
            this.carPassengers = carPassengers;
        }

        public LightCar(string carName, ushort Year, byte month, byte day, int carPassengers)
        {
            this.carName = carName;
            this.carYear = new DateTime(Year, month, day);
            this.carPassengers = carPassengers;
        }    
        
    }
}
