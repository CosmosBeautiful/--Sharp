using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<LightCar> lightPark = new CarCollection<LightCar>("Легковых авто");

            lightPark.Add(new LightCar("Toyota", new DateTime(2005, 1, 15), 4));
            lightPark.Add(new LightCar("Hyundai", 2001, 12, 4, 7));
            lightPark.Add(new LightCar("Nissan", 2009, 12, 6, 28));
            lightPark.Add(new LightCar("Mercedes-Benz", 2015, 12, 2, 16));
            lightPark.Add(new LightCar("Mazda", 2006, 5, 5, 19));
            lightPark.Add(new LightCar("BMW", 2017, 12, 11, 25));

            Console.WriteLine("Стоянка: {0} \n{1} ", lightPark.nameCollection, lightPark.ToString());

            Console.WriteLine(new string('-', 40));

            CarCollection<FreightCar> freighPark = new CarCollection<FreightCar>("Грузовых авто");

            freighPark.Add(new FreightCar("Ford", 2011, 12, 9, 7));
            freighPark.Add(new FreightCar("Kia", 2014, 8, 17, 28));
            freighPark.Add(new FreightCar("Volvo", 2010, 4, 10, 16));
            freighPark.Add(new FreightCar("Renault", 2003, 12, 14, 17));
            freighPark.Add(new FreightCar("Jeep", 2012, 3, 5, 25));

            Console.WriteLine("Стоянка: {0} \n{1} ", freighPark.nameCollection, freighPark.ToString());

            freighPark.Remove();

            Console.ReadKey();
        }
    }
}

//Создайте класс CarCollection<T>.
//Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин.
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, 
//индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.  
//Создайте метод удаления всех машин автопарка. 
