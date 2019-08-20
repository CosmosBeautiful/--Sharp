using System.Collections;

namespace Builder
{
    //Готовая продукция
    class Diary
    {
        ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}
