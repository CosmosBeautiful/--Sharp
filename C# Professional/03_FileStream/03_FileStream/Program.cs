using System;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.Text;

namespace _03_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            FileStream stream = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding(1251));

            writer.WriteLine("Hello World!");
            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }
            Console.WriteLine("В документ test.txt успешно был записан текст.\n");

            //Закрытие потока
            writer.Close();


            StreamReader reader = File.OpenText("test.txt");

            Console.WriteLine("Содержимое файла test.txt:");
            string input;
            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            //Закрытие потока
            reader.Close();
            #endregion

            #region GZipStream
            //Архив
            //
            // Создание файла и архива
            FileStream sours = File.OpenRead("test.txt");
            FileStream destination = File.Create("archive.zip");

            // Создание компрессора
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            // Заполнение архива
            int theByte;
            while ((theByte = sours.ReadByte()) != -1)
            {
                compressor.WriteByte((byte)theByte);
            }

            // Удаление компрессора.
            compressor.Close();

            //Декомпрессия
            destination = File.Create("test_zip.txt");
            sours = File.OpenRead("archive.zip");

            GZipStream deCompressor = new GZipStream(sours, CompressionMode.Decompress);

            while ((theByte = deCompressor.ReadByte()) != -1)
            {
                destination.WriteByte((byte)theByte);
            }

            // Удаление декомпрессора.
            deCompressor.Close();
            #endregion

            #region IsolatedStorageFileStream

            // Путь к хранилищу:
            // C:\Users\[USER NAME]\AppData\Local\IsolatedStorage

            //Получение изолированного хранилища, с областью действия пользователя, соответствующему вызову удостоверению сборки кода.
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();

            // Создание файлового потока с указанием: Имени файла, FileMode, объекта хранилища.
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStorage);

            //Запись данных в поток.
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("Test");
            userWriter.Close();

            Console.WriteLine("\nУспешно было создано - Изолированное хранилище.");

            //Проверка, если файл существует.
            string[] files = userStorage.GetFileNames("UserSettings.set");

            if (files.Length == 0)
            {
                Console.WriteLine("Нет данных, сохраненных для этого пользователя!");
            }
            else
            {
                // Прочитать данные из потока.
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStorage);

                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);
            }
            #endregion

            Console.ReadKey();
        }
    }
}

//Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте этот файл, 
//прочитайте из него данные и выведете их на консоль.
//Добавьте возможность сжатия файла и сохранять файл в изолированное хранилище.

