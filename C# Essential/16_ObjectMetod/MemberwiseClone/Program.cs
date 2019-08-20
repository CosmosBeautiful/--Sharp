using System;

namespace MemberwiseClone
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomHouse house1 = new RoomHouse(50, 2, "ул. Кирова", "Кирпич");

            //Клонирование объектов
            RoomHouse houseDeep1 = house1.DeepClone();
            RoomHouse houseSurfase1 = house1.SurfaceClone();

            //Выведем на экран результаты клонирования
            Console.WriteLine("Глубокое клонирование: " + houseDeep1);
            Console.WriteLine("Поверхностнре клонирование: " + houseSurfase1);
           
            //Изменим переменную ссылочного типа
            house1.typeHouse.type = "Панели";

            //Посмотрим результат изменения переменной 
            Console.WriteLine("---------------");
            Console.WriteLine("Глубокое клонирование: " + houseDeep1);
            Console.WriteLine("Поверхностнре клонирование: " + houseSurfase1);
            


            Console.ReadKey();


        }
    }
}

//Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное 
//и глубокое клонирование соответственно.Реализуйте простой способ проверки.