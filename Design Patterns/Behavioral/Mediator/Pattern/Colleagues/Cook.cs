using System;

namespace Mediator
{
    class Cook : Colleague
    {
        public Cook(Mediator mediator)
            : base(mediator)
        {
        }

        public void MakeOrder(string order)
        {
            Console.WriteLine($"Повар приготовил заказ: {order}");
            mediator.Send(order, this);
        }
    }
}
