using System;

namespace Decorator
{
    class BaconDecorator : Decorator
    {
        string becon = "Бекон";

        public override void MakePizza()
        {
            base.MakePizza();
            Console.WriteLine(becon);
        }
    }
}
