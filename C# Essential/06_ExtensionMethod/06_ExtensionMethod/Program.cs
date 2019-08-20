using System;

namespace ExtensionMethod
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 6, 7, 8, 3, 2, 4 , 9 };

            //ExtendMas.SortUp(array);
            array.SortUp();

            foreach (int a in array)
                Console.Write(a + "  ");

            Console.ReadKey();
        }
    }
}

//Требуется: создать расширяющий метод для целочисленного массива,
//который сортирует элементы массива по возрастанию.