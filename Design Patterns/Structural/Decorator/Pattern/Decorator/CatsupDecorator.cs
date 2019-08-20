using System;

namespace Decorator
{
    class CatsupDecorator : Decorator
    {
        void MakeCatsup()
        {
            Console.WriteLine("Томатный соус");
        }

        public override void MakePizza()
        {
            base.MakePizza();
            MakeCatsup();

        }
    }
}
