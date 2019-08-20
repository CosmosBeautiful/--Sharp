using System;

namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            var factoryFlyweight = new FlyweightFactory();

            #region Static Flyweight

            Console.WriteLine("Создание разделяемых (статичных) объектов");

            var flyweightA = factoryFlyweight.GetFlyweight("a");
            flyweightA.Operation(500);

            var duplicateFlyweightA = factoryFlyweight.GetFlyweight("a");
            duplicateFlyweightA.Operation(1);

            int stateA = (flyweightA as ConcreteFlyweight).objectState;
            Console.WriteLine($"a: {stateA}");

            #endregion

            #region Dynamic Flyweight

            Console.WriteLine("Создание неразделяемых (динамических) экземпляров");

            var dynamicFlyweightB = new UnsharedConcreteFlyweight();
            dynamicFlyweightB.Operation(7);
            Console.WriteLine($"b: {dynamicFlyweightB.instanceState}");

            #endregion

            Console.ReadKey();
        }
    }
}
