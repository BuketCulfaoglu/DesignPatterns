namespace VisitorPattern;

public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine("ConcreteVisitor: Visited ElementA");
    }

    public void Visit(ElementB element)
    {
        Console.WriteLine("ConcreteVisitor: Visited ElementB");
    }
}