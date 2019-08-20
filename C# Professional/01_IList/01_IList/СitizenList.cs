using System;
using System.Collections;

namespace _01_IList
{
    //Класс реализующий интерфейс IList
    class СitizenList : IList
    {
        private Citizen[] citizen = new Citizen[0];
        int count;

        public СitizenList()
        {
            count = 0;
        }

        #region IList
        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public object this[int index]
        {
            get
            {
                if((index >= 0) && (index < count))
                    return citizen[index];
                return null;
            }
            set
            {
                if ((index >= 0) && (index < count) && typeof(Citizen) == value.GetType())
                {
                    citizen[index] = (Citizen)value;
                }
            }
        }

    
        public int Add(object value)
        {
            
            Citizen[] citizen_new = new Citizen[count+1];
            citizen.CopyTo(citizen_new, 0);
            citizen_new[count] = (Citizen)value;
            count++;
            citizen = citizen_new;
            return count - 1;
        }

        // Определяет, содержится ли указанное значение в списке
        public bool Contains(object value)
        {
            Citizen Value = value as Citizen;
            if (Value != null)
            {
                for (int i = 0; i < count; i++)
                {
                    if (citizen[i] == Value)
                        return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            count = 0;
            citizen = new Citizen[0];
        }

        // Определяет индекс заданного элемента в списке
        public int IndexOf(object value)
        {
            Citizen Value = value as Citizen;
            if (Value != null)
            {
                for (int i = 0; i < count; i++)
                {
                    if (citizen[i] == Value)
                        return i;
                }
            }
            return -1;
        }

        // Вставляет элемент в коллекцию, с заданным индексом
        public void Insert(int index, object value)
        {
            Citizen Value = value as Citizen;
            if ((Value != null) && (index >= 0) && (index < count))
            {
                
                Citizen[] new_citizen = new Citizen[count + 1];
                for (int i = 0, j = 0; i < count; i++, j++)
                {
                    if (j == index)
                    {
                        new_citizen[j] = Value;
                        j++;
                    }
                    new_citizen[j] = citizen[i];
                }
                count++;
                citizen = new_citizen;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                count--;
                for (int i = index; i < count; i++)
                {
                    citizen[i] = citizen[i + 1];
                }
            }
        }

        #endregion

        #region ICollection
        public int Count
        {
            get { return count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return null; }
        }

        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < count; i++)
            {
                array.SetValue(citizen[i], j);
                j++;
            };
        }

        #endregion

        #region IEnumerable 

        // Возвращает перечислитель, который выполняет итерацию по элементам коллекции.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return citizen[i];
            }
        }
        #endregion
    }
}
