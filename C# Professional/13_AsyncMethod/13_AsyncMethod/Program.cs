using System;
using System.Threading;

namespace _13_AsyncMethod
{
    class Program
    {
        static int Sum(int x, int y)
        {
            Thread.Sleep(3000);  //Имитация вычислений
            return x + y;
        }

        static void Main(string[] args)
        {

            Func<int, int, int> myDel = new Func<int, int, int>(Sum);
            IAsyncResult asyncResult = myDel.BeginInvoke(5, 100, CallBack, myDel);

            //Выполнение цикла пока работает асинхронная операция
            while (!asyncResult.IsCompleted)
            {
                Thread.Sleep(100);
                Console.Write("+");
            }

            // Получение результата асинхронной операции, в первичном потоке
            //int result = myDel.EndInvoke(asyncResult);
            //Console.WriteLine("Результат = " + result);

            Console.ReadKey();
        }

        // Метод обработки завершения асинхронной операции.
        static void CallBack(IAsyncResult asyncResult)
        {
            Func<int, int, int> caller = (asyncResult.AsyncState as Func<int, int, int>);
            int sum = caller.EndInvoke(asyncResult);

            Console.WriteLine("Результат = {0}", sum);
        }

    }
}
