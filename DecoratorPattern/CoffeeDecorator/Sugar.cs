namespace DecoratorPattern.CoffeeDecorator
{
    internal class Sugar : CoffeeDecorator
    {
        public Sugar(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

    }
}
