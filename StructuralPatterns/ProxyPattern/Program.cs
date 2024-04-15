using ProxyPattern;


IPrimeMinister primeMinisterReal = new PrimeMinisterReal();
PrimeMinisterPen primeMinisterPen = new PrimeMinisterPen(primeMinisterReal);

Citizen citizen1 = new Citizen(primeMinisterPen);
citizen1.AskForJob("Baker");
Console.WriteLine(citizen1.TellIssue("Alex", "Car Park Stop Problem"));


Console.WriteLine(Environment.NewLine + "Other citizen..");


Citizen citizen2 = new Citizen(primeMinisterPen);
citizen2.AskForJob("Futball Player");
Console.WriteLine(citizen2.TellIssue("Jack", "A New Futball Stadium "));



