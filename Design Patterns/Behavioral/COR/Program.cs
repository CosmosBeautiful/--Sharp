using System;

namespace COR
{
    class Program
    {
        static void Main()
        {
            Handler firstSticker = new Sticker();
            Handler notebook = new Notebook();
            Handler diary = new Diary();

            firstSticker.SetNext(notebook).SetNext(diary);

            firstSticker.Request("Notebook", "Цепочка обязанности - позовляет ослабить связанность между объектами.");
            firstSticker.Request("Diary", "Следующий паттерн - Command");
            firstSticker.Request("Book", "Запрос пропадет.");

            Console.ReadKey();
        }
    }
}
