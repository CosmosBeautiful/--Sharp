using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Creator creator = null;
            Product product = null;

            creator = new PenCreator();
            product = creator.FactoryMethod();

            product.NameProduct();

            Console.ReadKey();
        }
    }
}
