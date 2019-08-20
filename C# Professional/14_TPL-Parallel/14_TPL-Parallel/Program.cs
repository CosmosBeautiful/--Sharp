using System;
using System.Threading;
using System.Threading.Tasks;


namespace _14_TPL_Parallel
{
    class Program
    {
        #region Task
        // Метод оттеняет асинхронную работу
        static void MethodTask(object symbol)
        {
            //По умолчанию IsBackground == true 
            //Thread.CurrentThread.IsBackground = false;

            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Task: запущен в потоке {0}", threadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write(symbol);
            }

            Console.WriteLine("\nTask: завершен в потоке {0}", threadId);
        }
        #endregion

        #region TaskReturn

        struct Variables
        {
            public int a;
            public int b;
        }

        // Метод который будет возвращать результат.
        static int Sum(object variables)
        {
            int a = ((Variables)variables).a;
            int b = ((Variables)variables).b;

            Thread.Sleep(1000);

            return a + b;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен");

            #region Task
            //Во вторичный поток
            Action<object> action = new Action<object>(MethodTask);
            Task taskSecondary = new Task(action, "+ ");
            taskSecondary.Start();

            //В основной поток
            Task taskMain = new Task(MethodTask, "/ ");
            taskMain.RunSynchronously();
            #endregion

            #region TaskReturn

            Variables variables;
            variables.a = 5;
            variables.b = 10;

            Task<int> taskSum = new Task<int>(Sum, variables);
            taskSum.Start();

            Console.WriteLine("Результат выполнения задачи Sum = " + taskSum.Result);
            #endregion

            #region Parallel
            Console.WriteLine("\n\nParallel");

            ParallelOptions options = new ParallelOptions();

            Console.WriteLine("Количество логических ядер CPU:" + Environment.ProcessorCount);
          
            options.MaxDegreeOfParallelism = 2;
            // Выполнить параллельно два метода.
            Parallel.Invoke(options, () => MethodTask("^"), () => MethodTask("_"));
            //Parallel приостанавливает основной поток 
            #endregion

            #region ParallelFor
            Console.WriteLine("\nПараллельный цикл for");

            int[] data = new int[1000000];

            Action<int> transform = (int i) => { data[i] = i; };

            // Инициализация данных в параллельном цикле for.
            Parallel.For(0, data.Length, transform);

            Console.WriteLine("Data[999999] = {0}", data[999999]);

            #endregion

            Console.WriteLine("Основной поток завершен");
            Console.ReadKey();
        }
    }
}
