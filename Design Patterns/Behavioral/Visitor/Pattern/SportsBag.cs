using System;

namespace Visitor
{
    class SportsBag : Bag
    {
        public override void TakeThing(Visitor visitor)
        {
            visitor.TakeThingSportsBag(this);
        }

        public void TakeSneakers()
        {
            Console.WriteLine("Взял кросовки.");
        }
    }
}
