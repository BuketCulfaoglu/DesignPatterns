namespace DecoratorPattern.CoffeeDecorator
{
    internal class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1.0; //Base cost of simple coffee
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
