using System;

namespace Abstract
{
    abstract class AbstractHandler
    {
        public string fileName;

        public AbstractHandler(string FileName)
        {
            fileName = FileName;
        }

        public void Open()
        {
            Console.WriteLine("Открыт файл " + fileName);
        }
        public void Create()
        {
            Console.WriteLine("Файл создан " + fileName);
        }
        public void Chenge()
        {
            Console.WriteLine("Файл изменен " + fileName);
        }

        public abstract void Save();
    }
}
