using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Gas
    {
        public void OperationA()
        {
            Console.WriteLine("Увелечение подачи воздуха и бензина.");
        }
        public void OperationB()
        {
            Console.WriteLine("Нарастающие обороты двигателя.");
        }
        public void OperationC()
        {
            Console.WriteLine("Передача оборотов через коробку передач и карданный вал.");
        }
        public void OperationD()
        {
            Console.WriteLine("Движение колес.");
        }
    }
}
