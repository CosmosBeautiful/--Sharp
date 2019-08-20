using System;

namespace AbstractFactoryNet
{
    class BlueHousing : IAbstractHousing
    {
        public void Assemble(IAbstractRod rod, IAbstractCap cap)
        {
            Console.WriteLine("Сборка синей ручки из {0}, {1}, {2}.", this, rod, cap);
        }
    }
}   
