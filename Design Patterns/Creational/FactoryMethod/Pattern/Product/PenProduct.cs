using System;

namespace FactoryMethod
{
    class PenProduct : Product
    {
        public override void NameProduct()
        {
            Console.WriteLine("Ручка");
        }
    }
}
