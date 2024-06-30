namespace ChainOfResponsibilityPattern;

public class InfoHandler : Handler
{
    public override void HandleRequest(LogMessage request)
    {
        if (request.Level == LogLevel.Info)
            Console.WriteLine($"Info: {request.Message}");
        else if (_successor != null)
            _successor.HandleRequest(request);
    }
}