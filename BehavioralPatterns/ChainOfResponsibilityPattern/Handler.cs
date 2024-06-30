namespace ChainOfResponsibilityPattern;

public abstract class Handler
{
    protected Handler _successor;

    public void SetSuccessor(Handler successor)
    {
        _successor = successor;
    }


    public abstract void HandleRequest(LogMessage request);
}