using System;

namespace Adapter
{
    class Pen : Write
    {
        public override void WriteWords()
        {
            Console.WriteLine(words);

        }
    }
}
