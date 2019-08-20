using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Writing prototype = null;
            Writing original = null;

            prototype = new PencilWriting("green");
            original = prototype.Clone();

            prototype = new PencilWriting("blue");
            original = prototype.Clone();

            Console.ReadKey();
        }
    }
}
