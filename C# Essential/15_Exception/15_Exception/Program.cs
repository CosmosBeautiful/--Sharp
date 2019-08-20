using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            Console.WriteLine("Введите Фамилию");
            worker.Name = Console.ReadLine();
           
            Console.WriteLine("Введите Должность");
            worker.Position = Console.ReadLine();

            
            //while(true) vs goto
            M: try
            {
                Console.WriteLine("Введите год поступления на работу");
                worker.Year = Convert.ToInt32(Console.ReadLine());
            }
            catch (YearException e)
            {
                e.MyMessageException();
                goto M;
            }


            Console.ReadLine();
        }
    }
}

//Требуется: Описать структуру с именем Worker, содержащую следующие поля:
//  фамилию сотрудника; 
//  название занимаемой должности; 
//  год поступления на работу.
//Написать программу, выполняющую следующие действия:
//  ввод с клавиатуры данных;
//  если значение года введено не в соответствующем формате выдает Исключение.


