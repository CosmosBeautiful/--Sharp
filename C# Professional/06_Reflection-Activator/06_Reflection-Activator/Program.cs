using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace _06_Reflection_Activator
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Assembly assembly = null;

            try
            {

                //Загрузка сборки
                //Сборка из 01_IList
                assembly = Assembly.Load("СitizenList");

                //Получаем все типы сборки
                Type[] types = assembly.GetTypes();
                foreach (Type t in types)
                    Console.WriteLine("Тип: {0}", t);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            try
            {
                // Создание экземпляра класса "на лету" (позднее связывание)
                Type type = assembly.GetType("СitizenList.Citizen");

                //Создания экземпляра типа во время выполнения.
                object instanceCitizen = Activator.CreateInstance(type, new object[] { "Никита", "Никитов", "74-48589" });

                //Поиск метода
                MethodInfo method = type.GetMethod("ToString");

                //Вызов метода 
                Console.WriteLine(method.Invoke(instanceCitizen, null));

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            try
            {
                //Созданный объект можно привести к интерфейсу
                Type typeСitizen = assembly.GetType("СitizenList.Citizen");
                object Сitizen1 = Activator.CreateInstance(typeСitizen, new object[] { "Никита", "Никитов", "74-48589" });
                object Сitizen2 = Activator.CreateInstance(typeСitizen, new object[] { "Олег", "Олегов", "74-56585" });

                Console.WriteLine("\nСоздание объекта, и работа с ним через интерфейс");
                Type typeСitizenList = assembly.GetType("СitizenList.СitizenList");
                IList СitizenList = Activator.CreateInstance(typeСitizenList) as IList; 

                Console.WriteLine("Добавление элементов в СitizenList");
                СitizenList.Add(Сitizen1);
                СitizenList.Add(Сitizen2);

                Console.WriteLine("\nВывод всех элементов: ");
                foreach (var item in СitizenList)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
