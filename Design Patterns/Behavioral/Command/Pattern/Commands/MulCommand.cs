namespace Command
{
    class MulCommand : Command
    {
        public MulCommand(ArithmeticCalculateReceiver arithmeticCalculate, int operand)
        {
            this.arithmeticCalculate = arithmeticCalculate;
            this.operand = operand;
        }

        public override void Execute()
        {
            arithmeticCalculate.Calculate('*', operand);
        }

        public override void UnExecute()
        {
            arithmeticCalculate.Calculate('/', operand);
        }
    }
}
