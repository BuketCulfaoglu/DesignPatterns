using ObserverPattern;

ConcreteSubject subject = new ConcreteSubject();

ConcreteObserver observer1 = new ConcreteObserver(subject);
ConcreteObserver observer2 = new ConcreteObserver(subject);

subject.Attach(observer1);
subject.Attach(observer2);

subject.State = "New State";

