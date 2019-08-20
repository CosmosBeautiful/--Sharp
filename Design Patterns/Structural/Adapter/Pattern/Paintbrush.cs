using System;

namespace Adapter
{
    class Paintbrush
    {
        public string drawing { get; set; }

        public void Draw()
        {
            Console.WriteLine(drawing);
        }
    }
}
