namespace Command
{
    abstract class Command
    {
        protected ArithmeticCalculateReceiver arithmeticCalculate;
        protected int operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
