using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            var dog = new Dog();

            dog.Hear(ActionDogType.Call); // AttentionDogState
            dog.Hear(ActionDogType.Call); // JoyDogState
            dog.Hear(ActionDogType.Scare); // MisunderstandDogState
            dog.Hear(ActionDogType.Scare); // SadnessDogState
            dog.Hear(ActionDogType.Scare); // OffendDogState
            dog.Hear(ActionDogType.Call); // MisunderstandDogState

            Console.ReadKey();
        }
    }
}
