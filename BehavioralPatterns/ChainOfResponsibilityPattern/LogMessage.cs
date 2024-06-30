namespace ChainOfResponsibilityPattern;

public class LogMessage
{
    public string Message { get; }
    public LogLevel Level { get; }

    public LogMessage(string message, LogLevel level)
    {
        Message = message;
        Level = level;
    }

}