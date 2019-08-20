using System;

namespace _14_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine("Перебор с помощью foreach");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

//Создайте коллекцию MyList<T>.Реализуйте в простейшем приближении возможность использования
//ее экземпляра аналогично экземпляру класса List<T>.Минимально требуемый интерфейс
//взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
//получения значения элемента по указанному индексу и свойство только для чтения для получения
//общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
//foreach.
