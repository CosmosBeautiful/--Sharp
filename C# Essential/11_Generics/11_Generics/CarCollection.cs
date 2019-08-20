using System;
using System.Collections.Generic;

namespace Generics
{
    class CarCollection<T> where T: ICar
    {
        public string nameCollection;
        List<T> cars = new List<T>();

        public CarCollection(string nameCollection)
        {
            this.nameCollection = nameCollection;
        }

        public void Add(T car)
        {
            cars.Add(car);
        }

        public T this[int index]
        {
            get { return cars[index]; }
        }
        public int Lenght
        {
            get { return cars.Count; }
        }

        public void Remove()
        {
            cars.Clear();
        }
        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < cars.Count; i++)
            {
                str += String.Format("№ {0} {1} {2:D} \n", i + 1, cars[i].CarName, cars[i].CarYear);
            }

            if (str == null)
            {
                str = "В отсутствуют машины";
            }
            return str;
        }
    }
}
