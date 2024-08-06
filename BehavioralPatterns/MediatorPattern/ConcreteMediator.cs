namespace MediatorPattern;

public class ConcreteMediator : IMediator
{
    private Colleague1 _colleague1;
    private Colleague2 _colleague2;

    public Colleague1 Colleague1
    {
        set { _colleague1 = value; }
    }

    public Colleague2 Colleague2
    {
        set { _colleague2 = value; }
    }

    public void SendMessage(string message, Colleague colleague)
    {
        if (colleague == _colleague1)
        {
            _colleague2.Notify(message);
        }
        else if (colleague == _colleague2)
        {
            _colleague1.Notify(message);
        }
    }
}