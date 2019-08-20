using System;
using System.Threading;

namespace _12_SynchronizingThreads
{
    class Program
    {
        static readonly Mutex Mutex = new Mutex(false, "Mutex:AF9B623F-188A-4D07-AA88-2238C654D27F");

        static AutoResetEvent AutoReser = new AutoResetEvent(false);


        #region Volatile
        static volatile bool stop; // Без JIT оптимизации.

        static void Function()
        {
            int x = 0;

            while (!stop)
            {
                x++;
            }

            Console.WriteLine("Поток остановлен при x = {0}", x);

            // Код метода после JIT оптимизации, если stop не volatile:
            //if (stop != true)
            //{
            //    Label:
            //    x++;
            //    goto Label;  // Оптимизация за счет чистого перехода без проверки условия.
            //}

        }
        #endregion

        #region ThreadPool
        static void Task(Object state)
        {
            Console.WriteLine("Запущен поток {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
        }

        static void Report()
        {
            Thread.Sleep(200);
            int availableWorkThreads, availableIOThreads, maxWorkThreads, maxIOThreads;
            ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIOThreads);
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);

            Console.WriteLine("Доступно рабочих потоков в пуле :{0} из {1}", availableWorkThreads, maxWorkThreads);
        }

        #endregion

        #region AutoResetEvent

        static void Run(Object state)
        {
            Console.WriteLine("Запущен поток: {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(200);
            }

            Console.WriteLine("\nПоток завершился: {0}", Thread.CurrentThread.ManagedThreadId);

            //Разблокирует, сигнальное состояние
            AutoReser.Set();
        }

        #endregion

        static void Main(string[] args)
        {
            //Приложение может выполняться только в одном экземпляре
            Mutex.WaitOne();

            #region Volatile

            Console.WriteLine("Volatile");
            Thread thread = new Thread(Function);
            thread.Start();

            Thread.Sleep(1000);
            //Останавливаем цикл.
            stop = true;
            thread.Join();

            #endregion

            #region ThreadPool

            Console.WriteLine("\nThreadPool");
            Report();
            //Добавляем задачу в Пул потоков.
            ThreadPool.QueueUserWorkItem(Task);
            ThreadPool.QueueUserWorkItem(Task);
            Report();

            #endregion

            #region AutoResetEvent

            Console.WriteLine("\nAutoResetEvent");
            ThreadPool.QueueUserWorkItem(Run);
            Console.WriteLine("Основной поток ожидает событие.");

            //Блокирует, несигнальное состояние
            AutoReser.WaitOne();
            Console.WriteLine("Основной поток получил событие и продолает выполнение.");

            ThreadPool.QueueUserWorkItem(Run);

            //Блокирует, несигнальное состояние
            AutoReser.WaitOne();
            Console.WriteLine("Основной поток получил событие и продолает выполнение.");

            #endregion

            Console.ReadKey();

            Mutex.ReleaseMutex();
        }
    }
}