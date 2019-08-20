using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = "String ";
            str += "являются ";
            str += "неизменяемым типом данных (Immutable) \n";
            Console.WriteLine(str);

            //Является очень быстрой строкой
            StringBuilder stringBuilder = new StringBuilder("StringBuilder ");
            stringBuilder.Append("является ");
            stringBuilder.Append("очень ").Append("быстрым. \n");

            Console.WriteLine(stringBuilder);

            //1
            Console.WriteLine("Поиск слов, начинающихся с t и состоявших только из букв.");
            string text = "text t4ted gem try@f ttt t'gfgt too 54";
            Regex reger = new Regex(@" [Tt]+[A-za-z]+ ");
            MatchCollection collection = reger.Matches(text);

            foreach (Match element in collection)
            {
                Console.WriteLine("{0,-5}  на {1} позиции.", element.Value, element.Index);
            }


            //2
            Console.WriteLine("\nЗаменяет в первой строке, подстроки  по соответствующему шаблону (или делигату)");
            text = "Выражение: 2 + 2 = 4";
            reger = new Regex("\\d");

            string answer = reger.Replace(text, m => (Int32.Parse(m.Value) * 2).ToString());

            Console.WriteLine(answer);

            //3
            Console.WriteLine(Regex.Replace("02/28/2007",                                          // Исходная строка
                                           @"(?<месяц>\d{1,2})/(?<день>\d{1,2})/(?<год>\d{2,4})",  // Шаблон
                                           "${день}.${месяц}.${год}"));                            // Новый формат
                

            // Delay.
            Console.ReadKey();
        }
    }
}
