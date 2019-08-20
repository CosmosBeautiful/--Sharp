using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Mega");

            store.AddArticle("Наушники", 2000);
            store.AddArticle("Клавиатура", 499.99);
            store.AddArticle("Мышка", 302);
            store.AddArticle("Колонки", 1555.55);
            store.AddArticle("Монитор", 5251.49);

            Console.WriteLine(store["Наушники"]);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(store[4]);
            Console.WriteLine(new string('-', 10));

            store.Show();

            Console.ReadKey();

        }
    }
}

//Создать класс Article, содержащий следующие закрытые поля: 
//• название товара; 
//• название магазина, в котором продается товар; 
//• стоимость товара в гривнах.
//Создать класс Store, содержащий закрытый массив элементов типа Article.  
//Обеспечить следующие возможности: 
//• вывод информации о товаре по номеру с помощью индекса; 
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
//Написать программу, вывода на экран информацию о товаре.
