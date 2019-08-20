using System.Collections;

namespace DifferentDictionaries
{
    //Переопределяем методы сравнения объектов.
    public class InsensitiveComparer : IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }
}
