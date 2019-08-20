using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            PizzaComponent pizza = new BasisPizzaComponent();
            Decorator bacon = new BaconDecorator();
            Decorator catsup = new CatsupDecorator();

            catsup.Component = pizza;
            bacon.Component = catsup;

            bacon.MakePizza();

            Console.ReadKey();
        }
    }
}
