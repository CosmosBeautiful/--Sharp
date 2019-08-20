namespace Iterator
{
    //interface
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; }
        public abstract Book this[int index] { get; set; }
        
    }
}
