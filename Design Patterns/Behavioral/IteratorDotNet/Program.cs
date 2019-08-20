using System;

namespace IteratorDotNet
{
    class Program
    {
        static void Main()
        {
            var library = new Library();

            library.Add(new Book("Туманность андромеды", "Ефремов", 2005));
            library.Add(new Book("Над пропастью во ржи", "Сэлинджер", 2016));
            library.Add(new Book("Война и мир", "Толстой", 1998));
            library.Add(new Book("Замок", "Кафка ", 2011));

            foreach (Book book in library)
            {
                Console.WriteLine($"Название: {book.Name}, Автор: {book.Author}, Год: {book.Year}.");
            }

            Console.ReadKey();
        }
    }
}
