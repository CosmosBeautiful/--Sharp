namespace Strategy
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(ref int[] array)
        {
            int len = array.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = len - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                    }
                }
            }
        }
    }
}
