namespace MediatorPattern;

public class Colleague1 : Colleague
{
    public Colleague1(IMediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Console.WriteLine("Colleague1 sends message: " + message);
        mediator.SendMessage(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Colleague1 gets message: " + message);
    }
}