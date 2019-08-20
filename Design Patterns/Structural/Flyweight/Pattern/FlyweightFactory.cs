using System.Collections;

namespace Flyweight
{
    class FlyweightFactory
    {
        Hashtable pool = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            if (pool.ContainsKey(key) == false)
            {
                pool.Add(key, new ConcreteFlyweight());
            }

            return pool[key] as Flyweight;
        }
    }
}
