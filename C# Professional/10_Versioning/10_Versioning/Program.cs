using System;

namespace _10_Versioning
{
    #region Versioning
    public class BaseClass
    {
        //Шаблонный метод = NVI (Non-Virtual Interface)
        public void DoWork()
        {
            SubstitutionWork();
            VirtualWork();
            OverlapWork();
            BanWork();
        }

        
        protected void SubstitutionWork() { Console.WriteLine("Замещение, Класс - Base"); }
        protected virtual void VirtualWork() { Console.WriteLine("Виртуальная функция, Класс - Base"); }
        protected virtual void OverlapWork() { Console.WriteLine("Перекрытие, Класс - Base"); }
        protected virtual void BanWork() { Console.WriteLine("Метод - BanWork, Класс - Base"); }

    }

    class DerivedClass : BaseClass
    {
        //Замещение
        protected new void SubstitutionWork() { Console.WriteLine("Замещение, Класс - Derived"); }

        //Виртуальная функция
        protected override void VirtualWork() { Console.WriteLine("Виртуальная функция, Класс - Derived"); }

        //Перекрытие
        protected new void OverlapWork() { Console.WriteLine("Перекрытие, Класс - Derived"); }

        //Запрет наследования
        protected sealed override void BanWork() { Console.WriteLine("Запрет наследования, Класс - Derived"); }
    }

    class DerivedFromDerivedClass : DerivedClass
    {
        //Запрет наследования
        //protected override void BanWork() { }

    }
    #endregion

    #region AdHoc
    // AdHoc полиморфизм
    public class OneClass { public void Method() { Console.WriteLine("OneClass"); } }
    public class TwoClass { public void Method() { Console.WriteLine("TwoClass"); } }
    public class ThreeClass { public void Method() { Console.WriteLine("ThreeClass"); } }


    interface IInterface { void Method(); }

    // Установка соответствия интерфейса и реализации
    class MyOneClass : OneClass, IInterface { }
    class MyTwoClass : TwoClass, IInterface { }
    class MyThreeClass : ThreeClass, IInterface { }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new DerivedClass();
            baseClass.DoWork();


            Console.WriteLine("\nAdHoc полиморфизм");
            // AdHoc полиморфизм
            //dynamic
            dynamic[] arrayClass = { new OneClass(), new TwoClass(), new ThreeClass() };

            foreach (var item in arrayClass)
                item.Method();


            //Interface
            IInterface MyClass = new MyOneClass();
            MyClass.Method();

            MyClass = new MyTwoClass();
            MyClass.Method();

            MyClass = new MyThreeClass();
            MyClass.Method();







            Console.ReadKey();
        }
    }
}
