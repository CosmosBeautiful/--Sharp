using System.Collections.Generic;

namespace Iterator
{
    class Library : Aggregate
    {
        List<Book> books = new List<Book>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public override int Count
        {
            get { return books.Count; }
        }
        public override Book this[int index]
        {
            get { return books[index]; }
            set { books.Insert(index, value); }

        }
    }
}
