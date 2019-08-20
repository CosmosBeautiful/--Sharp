using System;

namespace TemplateMethod
{
    class LacostePerfume : PerfumeAssembly
    {
        protected override void CreateBottle()
        {
            Console.WriteLine("Создание Lacoste флакона.");
        }

        protected override void CreateCaps()
        {
            Console.WriteLine("Создание Lacoste крышки.");
        }

        protected override void CreatePerfumeWater()
        {
            Console.WriteLine("Создание Lacoste парфюмерной воды.");
        }

        protected override void PouringPerfumeAndCloseCaps()
        {
            Console.WriteLine("Сборка Lacoste.");
        }
    }
}
