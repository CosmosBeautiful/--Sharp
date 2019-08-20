using System;
using System.Collections.Generic;

namespace Indexer
{
    class Store
    {
        public string Name { get; }
        List<Article> articls = new List<Article>();

        public Store(string storeName)
        {
            Name = storeName;
        }
        
        public string this[int index]
        {
            get
            {
                if (NotBeyondArray(index))
                    return articls[index].Info();
                else
                    return "Попытка обращения за пределы массива";
            }
        }


        public string this[string articleName]
        {
            get
            {
                for (int i = 0; i < articls.Count; i++)
                {
                    if (articls[i].Name == articleName)
                    {
                        return articls[i].Info();
                    }
                }
                return "Товар "+ articleName + " не найден.";
            }
        }

        private bool NotBeyondArray(int index)
        {
            bool flag = false;
            if (index >= 0 && index < articls.Count)
            {
                flag = true;
            }
            return flag;
        }

        public void AddArticle(string Name, double Price)
        {
            Article i = new Article(Name, Price); 
            articls.Add(i);
        }

        public void Show()
        {
            for (int i = 0; i < articls.Count; i++)
                Console.WriteLine(articls[i].Info());
        }
    }
}
