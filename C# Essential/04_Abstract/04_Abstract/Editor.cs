using System;

namespace Abstract
{
    class Editor
    {
        AbstractHandler document;
        bool flag = false;

        public void ChooseDocument(string FileName)
        {
            string format = FileName.Substring(FileName.Length - 4);
            

            switch (format.ToLower())
            {
                case ".xml":
                    {
                        document = new XMLHandler(FileName);
                        flag = true;
                        break;
                    }
                case ".txt":
                    {
                        document = new TXTHandler(FileName);
                        flag = true;
                        break;
                    }
                case ".doc":
                    {
                        document = new DOCHandler(FileName);
                        flag = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неопознаный формат");
                        break;
                    }
            }
        }


        public void Open()
        {   if(flag)
            document.Open();
        }

        public void Craete()
        {
            if (flag)
                document.Create();
        }

        public void Change()
        {
            if (flag)
                document.Chenge();
        }

        public void Save()
        {
            if (flag)
                document.Save();
        }
    }
}
