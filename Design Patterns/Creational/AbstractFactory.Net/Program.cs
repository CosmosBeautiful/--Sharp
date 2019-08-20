using System;

namespace AbstractFactoryNet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Зеленая ручка");
            Client client = new Client(Factory.GreenFactory);
            client.Run();

            Console.WriteLine("\nСиния ручка");
            client = new Client(Factory.BlueFactory);
            client.Run();

            // Задержка.
            Console.ReadKey();
        }
    }
}