using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            CalculatorClient calculator = new CalculatorClient();

            calculator.Add(5);
            Console.Write("5 + 6 = ({0})", calculator.Add(5));
            Console.Write(" * 11 = ({0})", calculator.Mul(11));
            Console.Write(" - 20 = ({0})", calculator.Sub(20));
            Console.WriteLine(" / 2 = ({0})", calculator.Div(2));

            Console.WriteLine("Undo(2) = ({0})", calculator.Undo(2));
            Console.WriteLine("Redo(1) = ({0})", calculator.Redo(1));

            Console.WriteLine("+ 5 = ({0})", calculator.Add(5));

            Console.ReadKey();
        }
    }
}
