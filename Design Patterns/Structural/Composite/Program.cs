using System;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            Component director = new TeamLeaderComposite("Директор");
            Component leaderWeb = new TeamLeaderComposite("Лидер - Web");
            Component leaderC = new TeamLeaderComposite("Лидер - C#");

            Component programmer1 = new ProgrammerLeaf("Программист 1");
            Component programmer2 = new ProgrammerLeaf("Программист 2");
            Component programmer3 = new ProgrammerLeaf("Программист 3");

            director.Add(leaderWeb);
            director.Add(leaderC);

            leaderWeb.Add(programmer1);
            leaderC.Add(programmer2);
            leaderC.Add(programmer3);

            director.Operation();

            Console.ReadKey();
        }
    }
}
