using System;
using System.Collections;
using System.Collections.Specialized;

namespace DifferentDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Different Dictionary
            //Хранит уникальные хэш-коды
            //Не рекомендуется, если размер будет меньше 10 элементов.
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "один");

            //Индексатор эквивалентен Add, если такого индекса не существует.
            hashtable[2] = "два";
            hashtable[2] = "two";

            //Организован по принципу массива. Подходит для небольшего количества элементов.
            ListDictionary listDictionary = new ListDictionary();

            //Меняет свое поведение между ListDictionary, Hashtable, в зависимости от количества элементов.
            HybridDictionary hybridDictionary = new HybridDictionary();

            //Элементы автоматически упорядочиваются по ключу.
            SortedList sortedList = new SortedList();

            //Сохраняет элементы в хронологическом порядке
            OrderedDictionary orderedDictionary = new OrderedDictionary();

            //Хранит только строговые ключ, значения.
            StringDictionary stringDictionary = new StringDictionary();

            //Позволяет под одним ключом хранить несколько значений.
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("1", "one");
            nameValueCollection.Add("1", "один");

            #endregion

            Hashtable dehash = new Hashtable(new InsensitiveComparer());

            dehash["Первый"] = "1-St";
            dehash["первый"] = "1-st";

            //Количество элементов = 1 
            Console.WriteLine(dehash.Count);

            Console.ReadKey();
        }
    }
}

//Несколькими способами создайте коллекций, в которой можно хранить "ключ - значение".
