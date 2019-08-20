using System.Collections;

namespace IteratorDotNet
{
    class BooksEnumerator : IEnumerator
    {
        private Library library;
        private int current = -1;

        public BooksEnumerator(Library library)
        {
            this.library = library;
        }

        public bool MoveNext()
        {
            if (current < library.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }

        public object Current
        {
            get { return library[current]; }
        }
    }
}
