using System;

namespace _01_IList
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen c1 = new Citizen("Макс","Макаров","74-8598");
            Citizen c2 = new Citizen("Олег", "Олегов", "74-3214");
            Citizen c3 = new Citizen("Павел", "Павлов", "74-1256");
            Citizen c4 = new Citizen("Роман", "Романов", "74-5486");
            Citizen c5 = new Citizen("Глеб", "Глебов", "74-9864");

            СitizenList сitizenList = new СitizenList();

            Console.WriteLine("Добавляем элементы в коллекцию");
            сitizenList.Add(c1);
            сitizenList.Add(c2);
            сitizenList.Add(c3);

            Console.WriteLine("Вставить элемент в середине коллекции");
            сitizenList.Insert(2, c4);

            Console.WriteLine("Добавить элемент в конец коллекции");
            сitizenList.Add(c4);

            Console.WriteLine("Ищем элемент из коллекции и заменяем его");
            сitizenList[сitizenList.IndexOf(c4)] = c5 ;

            Console.WriteLine("\nВыводим на экран коллекцию");
            foreach (Citizen index in сitizenList)
            {
                Console.WriteLine(index);
            }

            Console.ReadKey();

        }
    }
}

//Создать класс Гражданин.
//Создать непараметризированную коллекцию, реализующую интерфейс IList.
