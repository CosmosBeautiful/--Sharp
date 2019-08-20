using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exception
{
    struct Worker
    {
        private string name;
        private string position;
        private int year;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 50)
                {
                    year = value;
                }
                else
                {
                    //Console.WriteLine("Неверно введен год, повторите");
                    //Year = Convert.ToInt32(Console.ReadLine());
                    throw new YearException();

                }
            }
        }

    }
}
