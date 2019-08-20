using System;

namespace TemplateMethod
{
    class BossPerfume : PerfumeAssembly
    {
        protected override void CreateBottle()
        {
            Console.WriteLine("Создание Boss флакона.");
        }

        protected override void CreateCaps()
        {
            Console.WriteLine("Создание Boss крышки.");
        }

        protected override void CreatePerfumeWater()
        {
            Console.WriteLine("Создание Boss парфюмерной воды.");
        }

        protected override void PouringPerfumeAndCloseCaps()
        {
            Console.WriteLine("Сборка Boss.");
        }
    }
}
