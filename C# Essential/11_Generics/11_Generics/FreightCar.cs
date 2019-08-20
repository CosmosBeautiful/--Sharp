using System;

namespace Generics
{
    class FreightCar : ICar
    {
        private readonly string carName;
        private readonly DateTime carYear;
        private readonly int liftingPower;

        public string CarName { get { return carName; } }
        public DateTime CarYear { get { return carYear; } }
        public int LiftingPower { get { return liftingPower; } }

        public FreightCar(string carName, DateTime carYear, int liftingPower)
        {
            this.carName = carName;
            this.carYear = carYear;
            this.liftingPower = liftingPower;
        }
        public FreightCar(string carName, ushort Year, byte month, byte day, int liftingPower)
        {
            this.carName = carName;
            this.carYear = new DateTime(Year, month, day);
            this.liftingPower = liftingPower;
        }
    }
}
