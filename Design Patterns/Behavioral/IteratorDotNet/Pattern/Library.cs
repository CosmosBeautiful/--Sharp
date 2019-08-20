using System.Collections;
using System.Collections.Generic;

namespace IteratorDotNet
{
    class Library : IEnumerable
    {
        List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books.Insert(index, value);  }
        }

        public int Count
        {
            get { return books.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new BooksEnumerator(this);
        }
    }
}
