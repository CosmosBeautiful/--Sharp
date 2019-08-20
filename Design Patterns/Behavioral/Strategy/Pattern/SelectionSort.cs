using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SelectionSort : SortStrategy
    {
        public override void Sort(ref int[] array)
        {
            int len = array.Length;

            for (int i = 0; i < len - 1; i++)
            {
                int maxItem = i;

                for (int j = i + 1; j < len; j++)
                {
                    if (array[maxItem] > array[j])
                    {
                        maxItem = j;
                    }
                }

                if (maxItem != i)
                {
                    Swap(ref array[maxItem], ref array[i]);
                }
            }
        }
    }
}
