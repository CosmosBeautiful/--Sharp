using System;

namespace Facade
{
    class Brake
    {
        public void OperationA()
        {
            Console.WriteLine("Рычаг толкает поршень.");
        }
        public void OperationB()
        {
            Console.WriteLine("Нарастающие давление в тормозной жидкости.");
        }
        public void OperationC()
        {
            Console.WriteLine("В тормозном цилиндре колеса зажимает тормозную колодку.");
        }
    }
}
