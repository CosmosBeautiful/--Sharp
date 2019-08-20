namespace Strategy
{
    abstract class SortStrategy
    {
        public abstract void Sort(ref int[] array);

        protected void Swap(ref int firstArg, ref int secondArg)
        {
            int tmpParam = firstArg;
            firstArg = secondArg;
            secondArg = tmpParam;
        }
    }
}
