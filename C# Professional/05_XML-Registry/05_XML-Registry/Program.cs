using Microsoft.Win32;
using System;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace _05_XML_Registry
{
    class Program
    {
        static void Main(string[] args)
        {
            #region XmlWrite
            XmlTextWriter xmlWriter = new XmlTextWriter("test.xml", Encoding.GetEncoding(1251));

            
            xmlWriter.Formatting = Formatting.Indented; // Включить форматирование документа.
            xmlWriter.IndentChar = '\t';            // Для выделения уровня элемента использовать табуляцию.
            xmlWriter.Indentation = 1;              // использовать один символ табуляции.

            xmlWriter.WriteStartDocument();         // <?xml version="1.0"?>
            xmlWriter.WriteStartElement("Directory");

            xmlWriter.WriteStartElement("User");

            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString("Никита");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Language");
            xmlWriter.WriteStartAttribute("Standard");
            xmlWriter.WriteString("Ru-ru");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("русский");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("User");

            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString("Katy");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Language");
            xmlWriter.WriteStartAttribute("Standard");
            xmlWriter.WriteString("En-us");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("english");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            #endregion

            #region XPath

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("test.xml");

            XPathNavigator navigator = xmlDoc.CreateNavigator();

            XPathNodeIterator iterator = navigator.Select("Directory/User/Name");

            //Выведем всех пользователей.
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }

            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("Directory/User[2]/Language");
            XPathNodeIterator iterator2 = navigator.Select(expr);

            foreach (var item in iterator2)
                Console.WriteLine(item);
            #endregion

            #region Registry
            //regedit

            #region Write Registry
           
            try
            {

                Console.WriteLine("\nЗапись в реестр:");
                RegistryKey myKey = Registry.CurrentUser;

                //true говорит, что будет совершаться запись.
                RegistryKey softwareKey = myKey.OpenSubKey("Software", true);

                Console.WriteLine("Всего записей в {0}: {1}.", softwareKey.Name, softwareKey.SubKeyCount);

                // Попытка создать новый ключ.
                RegistryKey testProdKey = softwareKey.CreateSubKey("TestProduction");
                // Запись прошла успешно в HKEY_CURRENT_USER\Software\...

                Console.WriteLine("Запись \'{0}\' успешно внесена в реестр!", testProdKey.Name);
                Console.WriteLine("Теперь записей стало: {0}.", softwareKey.SubKeyCount);

                // Совершаем запись в реестр.
                testProdKey.SetValue("TheStringName", "Value text", RegistryValueKind.String); // Тип можно указать явно.
                testProdKey.SetValue("TheInt32Name", 1111);

                // Необходимо помнить.
                softwareKey.Close();
                myKey.Close();
            }
            catch (Exception e)
            {
                // Если возникает проблема - выводим сообщение о ней на экран.
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Read Registry

            //Чтение из реестра
            Console.WriteLine("\nЧтение из реестра:");

            try
            {
                RegistryKey userKey = Registry.CurrentUser;
                RegistryKey testProdKey = userKey.OpenSubKey(@"Software\TestProduction"); //можно сразу указать весь путь.
                
                // Читаем данные и конвертируем в нужный формат.
                string value1 = testProdKey.GetValue("TheStringName") as string;
                int value2 = Convert.ToInt32(testProdKey.GetValue("TheInt32Name"));

                Console.WriteLine("Значения: string = {0} int = {1}", value1, value2);

                // Необходимо помнить.
                userKey.Close();
                testProdKey.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            #endregion

            #region Delete Registry
            //Удаление из реестра
            Console.WriteLine("\nУдаление из реестра:");

            try
            {
                RegistryKey userKey = Registry.CurrentUser;
                RegistryKey testProdKey = userKey.OpenSubKey("Software",true);

                testProdKey.DeleteSubKey("TestProduction");

                Console.WriteLine("Созданный подраздел удален. Теперь записей стало: {0}.", testProdKey.SubKeyCount);

                // Необходимо помнить.
                userKey.Close();
                testProdKey.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}

//Знакомство с инструментами работы XML и Регистра.


