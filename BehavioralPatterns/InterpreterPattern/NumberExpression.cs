public class NumberExpression : AbstractExpression
{
    private readonly int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public override int Interpret(Context context)
    {
        return _number;
    }
}