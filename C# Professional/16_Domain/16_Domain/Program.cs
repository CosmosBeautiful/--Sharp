using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Threading;

namespace _16_Domain
{
    class DomainClass : MarshalByRefObject
    {
        public void Function(string str)
        {
            Console.WriteLine("{0, 15} -> Номер Домена : {1}", str, AppDomain.CurrentDomain.Id);
            Console.WriteLine("{0, 15} -> Номер Потока : {1} \n", str, Thread.CurrentThread.ManagedThreadId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Информация о Main
            DomainClass main = new DomainClass();
            main.Function("Main");

            //Создание домена
            AppDomain domain = AppDomain.CreateDomain("Second domain");

            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string typeName = typeof(DomainClass).FullName;


            try
            {
                // Создание объекта во втором домене.
                ObjectHandle handel = domain.CreateInstance(assemblyName, typeName);

                // Создание прозрачного прокси-переходника для взаимодействия с объектом из другого домена.
                DomainClass instance = handel.Unwrap() as DomainClass;

                // Вызов метода объекта, находящегося во втором домене.
                instance.Function("Second domain");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            // Выгрузка домена приложения.
            AppDomain.Unload(domain); 

            Console.ReadKey();
        }
    }
}
