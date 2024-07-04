namespace VisitorPattern;

public interface IVisitor
{
    void Visit(ElementA element);
    void Visit(ElementB element);
}