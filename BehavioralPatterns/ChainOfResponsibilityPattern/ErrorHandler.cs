namespace ChainOfResponsibilityPattern;

public class ErrorHandler : Handler
{
    public override void HandleRequest(LogMessage request)
    {
        if (request.Level == LogLevel.Error)
            Console.WriteLine($"Error: {request.Message}");
        else if (_successor != null)
            _successor.HandleRequest(request);
    }
}