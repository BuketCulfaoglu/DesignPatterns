using BuilderPattern;

var margheritaBuilder = new MargheritaPizzaBuilder();
var pepperoniBuilder = new PepperoniPizzaBuilder();


var margheritaDirector = new PizzaDirector(margheritaBuilder);
var pepperoniDirector = new PizzaDirector(pepperoniBuilder);

margheritaDirector.ConstructPizza();
pepperoniDirector.ConstructPizza();

var margheritaPizza = margheritaBuilder.GetPizza();
var pepperoniPizza = pepperoniBuilder.GetPizza();

margheritaPizza.Display();
pepperoniPizza.Display();