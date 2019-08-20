using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor document = new Editor();

            Console.WriteLine("Введите полное имя документа...");
            string FileName = Console.ReadLine();

            document.ChooseDocument(FileName);
            document.Open();
            document.Change();
            document.Save();

            Console.ReadKey();
        }
    }
}

//Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.  
