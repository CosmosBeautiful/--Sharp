using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            var lacostePerfume = new LacostePerfume();
            lacostePerfume.Assembly();

            Console.ReadKey();
        }
    }
}
