using System;
using System.Threading;

namespace _11_Thread
{



    class Program
    {
        #region Thread
        static void Function(char symbol)
        {
            Console.WriteLine("ID потока: {0}", Thread.CurrentThread.ManagedThreadId);

            try
            {
                //Оттеняем работу потока
                for (int i = 0; i < 200; i++)
                {
                    Thread.Sleep(10);
                    Console.Write(symbol);
                }
            }
            catch (ThreadAbortException)
            {

                Console.WriteLine("\nID потока: {0} - Прерван!", Thread.CurrentThread.ManagedThreadId);
            }
            

            Console.WriteLine("\nID потока: {0} завершился.", Thread.CurrentThread.ManagedThreadId);
        }
        #endregion

        #region Monitor

        static object block = new object();
        
        // Счетчик потоков.
        static int counter;

        static Random random = new Random();

        private static void MonitorFunction()
        {
            try
            {
                Monitor.Enter(block); // Начало блокировки. lock(block){
                counter++;
            }
            finally
            {
                Monitor.Exit(block);  // Конец блокировки. }
            }

            int wait = random.Next(1000, 12000);
            Thread.Sleep(wait);

            try
            {
                Monitor.Enter(block); // Начало блокировки.
                counter--;
            }
            finally
            {
                Monitor.Exit(block);  // Конец блокировки.
            }
        }

        // Мониторинг количества запущеных потоков.
        static void MonitorReport()
        {
            while (true)
            {
                int count;

                try
                {
                    Monitor.Enter(block); // Начало блокировки.
                    count = counter;
                }
                finally
                {
                    Monitor.Exit(block);  // Конец блокировки.
                }

                Console.WriteLine("{0} - потоков активно", count);
                Thread.Sleep(100);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Thread
            Console.WriteLine("Запуск вторичного потока. \nПриоритет = Низкий: ");
            Thread thread = new Thread(() => Function('.'));
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();

            Thread.Sleep(400);
            // Прервать выполнение потока (Генерируется исключение ThreadAbortException).
            //thread.Abort(); 
            // Первичный поток ожидает, завершения работы вторичного потока.
            //thread.Join();

            //Вторичный потом с приоритетом: Высокий.
            Console.WriteLine("\nЗапуск вторичного потока. \nПриоритет = Высокий: ");
            Thread thread2 = new Thread(() => Function('+'));
            thread2.Priority = ThreadPriority.Highest;
            thread2.Start();

            Thread.Sleep(100);

            Console.WriteLine("\nЗапуск первичного потока \nПриоритет = Нормальный:");
            Function('-');

            Console.ReadKey();
            #endregion

            #region Monitor

            Console.WriteLine("\n Блокировка потоков");
            //Фоновый поток
            Thread reporter = new Thread(MonitorReport) { IsBackground = true };
            reporter.Start();

            //Запуск потоков
            Thread[] threads = new Thread[20];
            for (uint i = 0; i < 20; i++)
            {
                threads[i] = new Thread(MonitorFunction);
                threads[i].Start();
            }

            #endregion

            Console.ReadKey();
        }
    }
}
