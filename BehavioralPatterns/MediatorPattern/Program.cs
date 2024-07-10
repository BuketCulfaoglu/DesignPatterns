using MediatorPattern;

ConcreteMediator mediator = new ConcreteMediator();

Colleague1 colleague1 = new Colleague1(mediator);
Colleague2 colleague2 = new Colleague2(mediator);

mediator.Colleague1 = colleague1;
mediator.Colleague2 = colleague2;

colleague1.Send("Hello, Colleague2!");
colleague2.Send("Hi, Colleague1!");
