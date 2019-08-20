using System;

namespace Mediator
{
    class Waiter : Colleague
    {
        public Waiter(Mediator mediator) 
            : base (mediator)
        {
        }

        public void TakeAnOrder(string order)
        {
            Console.WriteLine($"Официант принял заказ: {order}");
            mediator.Send(order, this);
        }

        public void GiveAnOrder(string order)
        {
            Console.WriteLine($"Официант отдал заказ: {order}");
            mediator.Send(order, this);
        }
    }
}
