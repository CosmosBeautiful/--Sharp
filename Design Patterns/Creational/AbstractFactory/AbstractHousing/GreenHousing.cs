using System;

namespace AbstractFactoryNet
{
    class GreenHousing : AbstractHousing
    {
        public override void Assemble(AbstractRod rod, AbstractCap cap)
        {
            Console.WriteLine("Сборка зеленой ручки из {0}, {1}, {2}.", this, rod, cap);
        }
    }
}
