using System.Collections;

namespace Visitor
{
    class ArrayBags
    {
        ArrayList bags = new ArrayList();
        
        public void Add(Bag bag)
        {
            bags.Add(bag);
        }

        public void Remove(Bag bag)
        {
            bags.Remove(bag);
        }

        public void TakeThings(Visitor visitor)
        {
            foreach (Bag bag in bags)
            {
                bag.TakeThing(visitor);
            }
        }
    }
}
