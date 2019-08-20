using System;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            var monitor = new Monitor(100, 50);
            var caretaker = new MonitorCaretaker();

            Console.WriteLine("Сохранить настройки:");
            monitor.ReadSettings();
            caretaker.MonitorMemento = monitor.SaveSettings();

            monitor.Brightness = 10;
            monitor.Contrast = 77;
            Console.WriteLine("Настройки поменяли:");
            monitor.ReadSettings();

            monitor.SetSettings(caretaker.MonitorMemento);
            Console.WriteLine("Востановили настройки:");
            monitor.ReadSettings();

            Console.ReadKey();
        }
    }
}
