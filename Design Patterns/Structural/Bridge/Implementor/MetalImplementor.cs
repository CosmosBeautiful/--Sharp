using System;

namespace Birdge
{
    class MetalImplementor : MaterialImplementor
    {
        public override void Pour()
        {
            Console.WriteLine("из метала.");
        }
    }
}
