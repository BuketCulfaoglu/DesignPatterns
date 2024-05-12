namespace BuilderPattern
{
    internal class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough()
        {
            _pizza.Dough = "thin crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "tomato";
        }

        public void BuildTopping()
        {
            _pizza.Topping = "mozzarella cheese";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
