using System;

namespace COR
{
    class Diary : Handler
    {
        public override void Request(string name, string text)
        {
            if (name == "Diary")
            {
                Console.WriteLine("Ежедневник: " + text);
            }
            else
            {
                base.Request(name, text);
            }
        }
    }
}
