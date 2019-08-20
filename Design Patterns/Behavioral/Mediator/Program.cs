using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var mediator = new ConcreteMediator();
            var waiter = new Waiter(mediator);
            var cook = new Cook(mediator);

            mediator.Waiter = waiter;
            mediator.Cook = cook;

            Console.WriteLine("Официант ожидает заказ:");
            string order = Console.ReadLine();
            waiter.TakeAnOrder(order);

            Console.ReadKey();
        }
    }
}
