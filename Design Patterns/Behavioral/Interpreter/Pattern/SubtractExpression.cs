namespace Interpreter
{
    class SubtractExpression : AbstractExpression
    {
        AbstractExpression leftExpression;
        AbstractExpression rightExpression;

        public SubtractExpression(AbstractExpression leftExpression, AbstractExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public override int Interpret(Context context)
        {
            return leftExpression.Interpret(context) - rightExpression.Interpret(context);
        }
    }
}
