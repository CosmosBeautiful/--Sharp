using System;

namespace _09_Delegates
{
    class Program
    {
        delegate double MyDelegate(int x, int y);

        static void Main(string[] args)
        {
            MyDelegate Add = delegate(int x, int y) { return x + y; };
            MyDelegate Sub = (int x, int y) => { return x - y; };
            MyDelegate Mul = (x, y) => x * y;

            MyDelegate Div = (int x, int y) => 
            {
                if (y == 0)
                {
                    Console.WriteLine("Деление на ноль!");
                    return 0;
                }
                return x / y;
            };

            int a, b;
            Console.WriteLine("Введите два числа: ");
            try
            {
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                a = 1;
                b = 1;
                Console.WriteLine("Ошибка ввода");
            }
            

            Console.WriteLine("Сложение {0}", Add.Invoke(a, b));
            Console.WriteLine("Вычитание {0}", Sub.Invoke(a, b));

            Console.WriteLine("Умножение {0}", Mul(a, b));
            Console.WriteLine("Деление {0}", Div(a, b));

            //
            //Второй способ
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите оператор +,-,*,/");
            string op = Convert.ToString(Console.ReadLine());

            MyDelegate multi = null;

            switch (op)
            {
                case "+":
                    multi = (x, y) => x + y;
                    break;
                case "-":
                    multi = (x, y) => x - y;
                    break;
                case "*":
                    multi = (x, y) => x * y;
                    break;
                case "/":
                    multi = (x, y) =>
                    {
                        if (y == 0)
                        {
                            Console.WriteLine("Деление на ноль!");
                            return 0;
                        }
                        return x / y;
                    };
                    break;
                default:
                    Console.WriteLine("Неправильно введен знак операции!");
                    break;
            }

            if(multi != null)
            {
                Console.WriteLine("{0:##.###}", multi(a, b));
            }

            Console.ReadKey();
        }
    }
}

//Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
//Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
//Лямбда оператор деления должен делать проверку деления на ноль.
//Написать программу, которая будет выполнять арифметические действия, указанные пользователем.

