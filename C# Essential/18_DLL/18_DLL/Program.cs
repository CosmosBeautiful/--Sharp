using System;
using LibraryDictionary; //Подключение собственной библиотеки, в которой содержится класс MyDictionary

namespace _18_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(0, "zero");
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");

            Console.WriteLine("Обращение по индексу " + dictionary[1]);

            foreach (string index in dictionary)
            {
                Console.WriteLine(index);
            }

            Console.ReadKey();
        }
    }
}

//Реализуйте возможность подключить собственную библеотеку классов MyDictionary<Tkey, TVakue>.