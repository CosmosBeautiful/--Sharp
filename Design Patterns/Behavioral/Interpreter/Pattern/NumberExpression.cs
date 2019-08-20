namespace Interpreter
{
    class NumberExpression : AbstractExpression
    {
        string name;
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public override int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
