namespace ChainOfResponsibilityPattern;

public class WarningHandler : Handler
{
    public override void HandleRequest(LogMessage request)
    {
        if (request.Level == LogLevel.Warning)
            Console.WriteLine($"Warning: {request.Message}");
        else if (_successor != null)
            _successor.HandleRequest(request);
    }
}