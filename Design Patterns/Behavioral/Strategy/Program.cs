using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            #region Bubble Sort
            Console.WriteLine("Bubble Sort");
            var bubbleSort = new BubbleSort();
            var bubbleSortContext = new Context(bubbleSort);

            bubbleSortContext.Sort();
            bubbleSortContext.PrintArray();
            #endregion

            #region Insertion Sort
            Console.WriteLine("Insertion Sort");
            var insertionSort = new InsertionSort();
            var insertionSortContext = new Context(insertionSort);

            insertionSortContext.Sort();
            insertionSortContext.PrintArray();
            #endregion

            #region Selection Sort
            Console.WriteLine("Selection Sort");
            var selectionSort = new SelectionSort();
            var selectionSortContext = new Context(selectionSort);

            selectionSortContext.Sort();
            selectionSortContext.PrintArray();
            #endregion

            Console.ReadKey();
        }
    }
}
