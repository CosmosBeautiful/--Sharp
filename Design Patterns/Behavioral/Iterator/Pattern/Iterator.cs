namespace Iterator
{
    //interface
    abstract class Iterator
    {
        public abstract Book First();
        public abstract Book Next();
        public abstract bool IsDone();
        public abstract Book CurrentItem();
    }
}
