using System.Collections;

namespace Builder
{
    //Готовая продукция
    class Notebook
    {
        ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}
