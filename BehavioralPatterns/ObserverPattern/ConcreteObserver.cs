namespace ObserverPattern
{
    internal class ConcreteObserver : IObserver
    {
        private readonly ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Observer received updated state: {_subject.State}");
        }
    }
}
