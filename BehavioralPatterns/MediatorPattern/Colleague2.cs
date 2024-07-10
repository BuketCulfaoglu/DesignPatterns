namespace MediatorPattern;

public class Colleague2 : Colleague
{
    public Colleague2(IMediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Console.WriteLine("Colleague2 sends message: " + message);
        mediator.SendMessage(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Colleague2 gets message: " + message);
    }
}