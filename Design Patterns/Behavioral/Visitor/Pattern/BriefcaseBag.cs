using System;

namespace Visitor
{
    class BriefcaseBag: Bag
    {
        public override void TakeThing(Visitor visitor)
        {
            visitor.TakeThingBriefcaseBag(this);
        }

        public void TakeDocuments()
        {
            Console.WriteLine("Взял документы.");
        }
    }
}
