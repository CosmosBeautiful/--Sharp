using System;
using System.Collections;
using System.Collections.Generic;

namespace _14_Collection
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array = null;
        private int position;
       
        public int Length { get { return array.Length; } }

        public MyList()
        {
            array = new T[0];
            position = -1;
        }

        object IEnumerator.Current 
        {
            get { return array[position]; }
        }

        public T Current
        {
            get { return array[position]; }
        }

        public bool MoveNext() //Проверяет и сдвигает на позицию вперед. 
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset() 
        {
            position = -1;
        }

        //Реализация интерфейса IEnumerable<T>
        public void Dispose()
        {
            Reset();
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }

        //Метод добавления элемента
        public void Add(T elem)
        {
            T[] array_new = new T[array.Length + 1];
            array.CopyTo(array_new, 0);
            array_new[array.Length] = elem;
            array = array_new;
        }

        //Индексатор 
        public T this[int index]
        {
            get
            {
                try
                {
                    return array[index];
                }
                catch (Exception)
                {
                    throw new InvalidOperationException();
                }
            }
        }


    }
}
