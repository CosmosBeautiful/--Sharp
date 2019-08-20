using System;

namespace AbstractFactoryNet
{
    class BlueHousing : AbstractHousing
    {
        public override void Assemble(AbstractRod rod, AbstractCap cap)
        {
            Console.WriteLine("Сборка синей ручки из {0}, {1}, {2}.", this, rod, cap);
        }
    }
}
