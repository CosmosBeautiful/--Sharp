using System;
using System.Threading;
using System.Threading.Tasks;

namespace _14_AsyncAwait
{
    class Program
    {
        class MyClass
        {
            public int Method()
            {
                Console.WriteLine("Метод:ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Начало");
                Thread.Sleep(2000);
                Console.WriteLine("\nКонец");

                return 2 + 2;
            }

            public async Task<int> MethodAsync()
            {
                //Выполняться будет в контексте первичного потока.
                Console.WriteLine("МетодАсинхронный (Часть I) ThreadID {0}\n", Thread.CurrentThread.ManagedThreadId);

                //Task task = new Task(Method);
                //task.Start();

                var Result = await Task<int>.Factory.StartNew(Method);
                
                //Выполняться будет в контексте вторичного потока.
                Console.WriteLine("\nМетодАсинхронный (Часть II) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

                return Result;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Начало Main ThreadID {0}\n", Thread.CurrentThread.ManagedThreadId);

            MyClass my = new MyClass();
            Task<int> task = my.MethodAsync();

            //Будет выполнена когда асинхронная операция вернет результат
            task.ContinueWith(t => Console.WriteLine("Результат выполнения Асинхронного метода: {0} \n", t.Result));

            //Поток Main продолжает выполнение
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
                Console.Write("+ ");
            }

            Console.WriteLine("\nКонец Main");
            Console.ReadKey();
        }
    }
}
