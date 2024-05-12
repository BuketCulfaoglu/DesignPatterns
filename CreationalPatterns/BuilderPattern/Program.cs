using BuilderPattern;

var margheritaBuilder = new MargheritaPizzaBuilder();

var director = new PizzaDirector(margheritaBuilder);

director.ConstructPizza();
var margheritaPizza = margheritaBuilder.GetPizza();

margheritaPizza.Display();