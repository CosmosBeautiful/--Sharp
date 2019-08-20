using System;

namespace Strategy
{
    class Context
    {
        SortStrategy sortStrategy;

        int[] array = { 4, 5, 7, 45, 12, 95, 8, 36, 100 };

        public Context(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Sort()
        {
            sortStrategy.Sort(ref array);
        }

        public void PrintArray()
        {
            foreach(int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
