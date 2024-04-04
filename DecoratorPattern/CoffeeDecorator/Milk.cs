namespace DecoratorPattern.CoffeeDecorator
{
    internal class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() + 1.2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }
    }
}
