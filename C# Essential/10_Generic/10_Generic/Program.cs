using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            Random ran = new Random(); 
            for (int i = 0; i < 10; i++)
            {
                list.Add(ran.Next(100)); 
            }

            Console.WriteLine("Количество элментов в листе: {0}", list.Count);
            Console.WriteLine("Элменты : {0}", list.ToString());

            list.Clear();

            Console.ReadKey();

        }
    }
}
