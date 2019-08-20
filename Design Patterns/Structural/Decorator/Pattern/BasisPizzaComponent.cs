using System;

namespace Decorator
{
    class BasisPizzaComponent : PizzaComponent
    {
        string dough = "Тесто";
        string cheese = "Сыр";

        public override void MakePizza()
        {
            Console.WriteLine("{0} и {1}",dough, cheese);
        }
    }
}
