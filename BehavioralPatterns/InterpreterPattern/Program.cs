Context context = new Context();
context.SetVariable("x", 5);
context.SetVariable("y", 10);

AbstractExpression expression = new AddExpression(
    new NumberExpression(2),
    new SubtractExpression(
        new VariableExpression("x"),
        new VariableExpression("y")
    )
);

int result = expression.Interpret(context);
Console.WriteLine($"Result: {result}");