using System;

namespace _09_GC_Dispose
{
    class MyClassWrite
    {
        ~MyClassWrite()
        {
            for (int i = 0; i < 80; i++)
                Console.Write("|");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClassWrite myw = new MyClassWrite();
            //Принудительная сборка мусора.
            GC.Collect();
            // Garbage Collector может полностью преостанавливать текуший поток.
            // для проверки, требуется включить оптимизацию  
            GC.WaitForPendingFinalizers(); 

            for (int i = 0; i < 80; i++)
                Console.Write(".");

            //
            Console.WriteLine("\n\nШаблон Microsoft для освобождения ресурсов");
            MyClass my = new MyClass();
            for (int i = 0; i < 5; i++)
                my.Dispose();

            Console.ReadKey();

        }
    }
}

// Разобрать шаблон Microsoft для освобождения ресурсов.
// Данный паттерн гарантирует, что пользователь, сможет многократно вызывать метод Dispose().
