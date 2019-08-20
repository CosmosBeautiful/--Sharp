using System;

namespace COR
{
    class Sticker : Handler
    {
        public override void Request(string name, string text)
        {
            if (name == "Sticker")
            {
                Console.WriteLine("Стикер: " + text);
            }
            else
            {
                base.Request(name, text);
            }
        }

    }
}
