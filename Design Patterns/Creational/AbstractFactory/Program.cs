using System;

namespace AbstractFactoryNet
{
    class Program
    {
        static void Main()
        {
            Client client;

            Console.WriteLine("Синия ручка");
            client = new Client(new BlueFactory());
            client.Run();

            Console.WriteLine("\nЗеленая ручка");
            client = new Client(new GreenFactory());
            client.Run();

            Console.ReadKey();
        }
    }
}