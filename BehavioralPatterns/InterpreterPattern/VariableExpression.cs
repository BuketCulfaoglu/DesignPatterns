public class VariableExpression : AbstractExpression
{
    private readonly string _name;

    public VariableExpression(string name)
    {
        _name = name;
    }

    public override int Interpret(Context context)
    {
        return context.GetVariable(_name);
    }
}