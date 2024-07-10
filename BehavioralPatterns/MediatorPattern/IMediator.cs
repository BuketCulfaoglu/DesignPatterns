namespace MediatorPattern;

public interface IMediator
{
    void SendMessage(string message, Colleague colleague);
}