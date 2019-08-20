using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Post worker = Post.Developer;
            int hours = 190;
            bool premium = Accauntant.AskForBonus(worker, hours);

            Console.WriteLine("Дать сотруднику {0} отработавшему {1} премию: {2} ", worker, hours, premium);

            Console.ReadKey();
        }
    }
}

//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.  
//Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. 
//Если сотрудник отработал больше положеных часов в месяц, то ему положена премия. 
