namespace Strategy
{
    class InsertionSort : SortStrategy
    {
        public override void Sort(ref int[] array)
        {
            int len = array.Length;

            for (int i = 1; i < len; i++)
            {
                int j = 0;
                int buffer = array[i];

                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                    {
                        break;
                    }

                    array[j + 1] = array[j];
                }

                array[j + 1] = buffer;
            }
        }
    }
}
