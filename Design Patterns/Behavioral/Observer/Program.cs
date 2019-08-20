using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            GroupAccountSubject groupAccount = new GroupAccountSubject("Green", new ResourcesGroup());

            PlayerGroup nikita = new PlayerGroup("Nikita", groupAccount);
            PlayerGroup max = new PlayerGroup("Max", groupAccount);
            PlayerGroup oleg = new PlayerGroup("Oleg", groupAccount);
            PlayerGroup ilya = new PlayerGroup("Ilya", groupAccount);
            groupAccount.Attach(nikita);
            groupAccount.Attach(max);
            groupAccount.Attach(oleg);
            groupAccount.Attach(ilya);

            Console.WriteLine("Игроки вступили в группу.");

            nikita.GoldExtractionResource(600);
            max.GoldExtractionResource(500);
            ilya.ForestExtractionResource(120);
            max.GoldExtractionResource(100);
            oleg.ForestExtractionResource(100);

            nikita.StatusPlayerGroup();
            max.StatusPlayerGroup();
            oleg.StatusPlayerGroup();
            ilya.StatusPlayerGroup();

            Console.ReadKey();
        }
    }
}
