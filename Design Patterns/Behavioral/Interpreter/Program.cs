using System;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            Context context = new Context();
            context.SetVariable("A", 50);
            context.SetVariable("B", 6);
            context.SetVariable("C", 15);

            Console.Write("A * B = ");
            AbstractExpression multiplyExpression = new MultiplyExpression(new NumberExpression("A"), new NumberExpression("B"));
            int multiplyResult = multiplyExpression.Interpret(context);
            Console.WriteLine(multiplyResult);

            Console.Write("(A * B) - C = ");
            AbstractExpression expression = new SubtractExpression(multiplyExpression, new NumberExpression("C"));
            int result = expression.Interpret(context);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
