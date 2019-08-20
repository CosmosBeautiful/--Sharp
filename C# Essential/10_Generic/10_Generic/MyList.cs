namespace Generic
{
    class MyList<T> : IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a)
        {
            int length = array.Length;
            T[] tempArray = new T[length + 1];
            for (int i = 0; i < length ; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[length] = a;
            array = tempArray;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length;  }
        }

        public void Clear()
        {
            array = new T[0];
        }

        public override string ToString() // Переопределение базового класса object
        {
            string str = null;
            for(int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return str;
        }
    }
}
