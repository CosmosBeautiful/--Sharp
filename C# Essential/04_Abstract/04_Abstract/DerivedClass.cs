using System;

namespace Abstract
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string FileName)
            :base(FileName)
        {
            Console.WriteLine("XML");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранен XML документ " + fileName);
        }
    }
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string FileName)
            : base(FileName)
        {
            Console.WriteLine("DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранен DOC документ " + fileName);
        }
    }
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string FileName)
            : base(FileName)
        {
            Console.WriteLine("TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранен TXT документ " + fileName);
        }
    }
}
