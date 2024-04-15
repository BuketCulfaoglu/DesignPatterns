namespace DecoratorPattern.CoffeeDecorator
{
    internal class WhippedCream : CoffeeDecorator
    {
        public WhippedCream(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 3.1;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Whipped Cream";
        }
    }
}
