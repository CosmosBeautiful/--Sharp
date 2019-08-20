namespace Command
{
    class ArithmeticCalculateReceiver
    {
        public int Value { get; private set; }

        public void Calculate(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Value += operand;
                    break;
                case '-':
                    Value -= operand;
                    break;
                case '*':
                    Value *= operand;
                    break;
                case '/':
                    Value /= operand;
                    break;
            }
        }

    }
}
