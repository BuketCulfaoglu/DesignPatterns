namespace BuilderPattern
{
    internal class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructPizza()
        {
            _builder.BuildDough();
            _builder.BuildSauce();
            _builder.BuildTopping();
        }
    }
}
