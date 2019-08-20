namespace Interpreter
{
    class AddExpression : AbstractExpression
    {
        AbstractExpression leftExpression;
        AbstractExpression rightExpression;

        public AddExpression(AbstractExpression leftExpression, AbstractExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public override int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}
