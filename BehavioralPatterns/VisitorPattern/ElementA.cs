namespace VisitorPattern;

public class ElementA : Element
{
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}