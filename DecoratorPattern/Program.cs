using DecoratorPattern.CoffeeDecorator;

ICoffee coffee = new SimpleCoffee();
coffee = new Milk(coffee);
coffee = new Sugar(coffee);

Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost().ToString("0.00"));