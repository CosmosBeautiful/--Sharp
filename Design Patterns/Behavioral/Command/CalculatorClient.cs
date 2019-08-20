namespace Command
{
    class CalculatorClient
    {
        ArithmeticCalculateReceiver arithmeticCalculate;
        CalculateInvoker calculate;

        public CalculatorClient()
        {
            this.arithmeticCalculate = new ArithmeticCalculateReceiver();
            this.calculate = new CalculateInvoker();
        }

        private int Calculate(Command command)
        {
            calculate.StoreCommand(command);
            calculate.ExecuteCommand();
            return arithmeticCalculate.Value;
        }

        public int Add(int operand)
        {
            return Calculate(new AddCommand(arithmeticCalculate, operand));
        }

        public int Sub(int operand)
        {
            return Calculate(new SubCommand(arithmeticCalculate, operand));
        }

        public int Mul(int operand)
        {
            return Calculate(new MulCommand(arithmeticCalculate, operand));
        }

        public int Div(int operand)
        {
            return Calculate(new DivCommand(arithmeticCalculate, operand));
        }

        public int Undo(int levels)
        {
            calculate.Undo(levels);
            return arithmeticCalculate.Value;
        }

        public int Redo(int levels)
        {
            calculate.Redo(levels);
            return arithmeticCalculate.Value;
        }
    }
}
