using System;

namespace Facade
{
    class Ignition
    {
        public void OperationA()
        {
            Console.WriteLine("Подача тока.");
        }
        public void OperationB()
        {
            Console.WriteLine("Получение тока высокого напряжения.");
        }
        public void OperationC()
        {
            Console.WriteLine("Зажигание свечей.");
        }
    }
}
