﻿public class AddExpression : AbstractExpression
{
    private readonly AbstractExpression _leftExpression;
    private readonly AbstractExpression _rightExpression;

    public AddExpression(AbstractExpression leftExpression, AbstractExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public override int Interpret(Context context)
    {
        return _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
    }
}