using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryDictionary
{
    public class MyDictionary<TKey, TValue> : IEnumerable<string>
    {
        private List<TKey> key;
        private List<TValue> value;

        public MyDictionary()
        {
            key = new List<TKey>();
            value = new List<TValue>();
        }

        public int Length
        {
            get { return key.Count; }
        }

        public void Add(TKey Key, TValue Value)
        {
            key.Add(Key);
            value.Add(Value);
        }

        public TValue this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if (key[i].Equals(index))
                        return value[i];
                }

                return default(TValue);
            }
        }

        //IEnumerator
        private int position = -1;

        public IEnumerator<string> GetEnumerator()
        {
            while (true)
            {
                if (position < key.Count - 1) //Пока не достигнут конец списка
                {
                    position++;
                    yield return String.Format("Ключ: {0} Знвчение: {1}", key[position], value[position]);
                }
                else
                {
                    position = -1;
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield break;
        }
       
    }
}
