using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            var bags = new ArrayBags();
            bags.Add(new SportsBag());
            bags.Add(new BriefcaseBag());

            bags.TakeThings(new ManVisitor());

            Console.ReadKey();
        }
    }
}
