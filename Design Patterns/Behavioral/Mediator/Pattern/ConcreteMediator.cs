using System.Collections.Generic;

namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        public Waiter Waiter { get; set; }
        public Cook Cook { get; set; }

        List<string> orders = new List<string>();

        public override void Send(string order, Colleague colleague)
        {

            if (colleague == Waiter)
            {
                if ( orders.Contains(order) == false )
                {
                    orders.Add(order);
                    Cook.MakeOrder(order);
                }
            }
            else if (colleague == Cook)
            {
                Waiter.GiveAnOrder(order);
            }
        }
    }
}
