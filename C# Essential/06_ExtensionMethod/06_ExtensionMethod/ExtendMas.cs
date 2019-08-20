namespace ExtensionMethod
{
    static class ExtendMas
    {
        public static void SortUp(this int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }
        }
    }
}
