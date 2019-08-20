using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(16,44,5);
            Block block2 = new Block(18, 31, 4);

            Console.WriteLine("Равны ли блоки? \nБлок 1 = {0} \nБлок 2 = {1}", block1, block2); 
            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine("Хэш-коды блоков: {0}, {1}", block1.GetHashCode(), block2.GetHashCode());

            Console.WriteLine("\n-------");
            block2.length = 16;
            block2.width = 44;
            block2.height = 5;
            Console.WriteLine("Изменим Блок 2 {0} \nИ сравним теперь с блоком 1:", block2);
            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine("Хэш-коды блоков: {0}, {1}", block1.GetHashCode(), block2.GetHashCode());

            Console.ReadKey();
        }
    }
}

//Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
//Equals – способный сравнивать блоки между собой,
//ToString – возвращающий информацию о полях блока. 