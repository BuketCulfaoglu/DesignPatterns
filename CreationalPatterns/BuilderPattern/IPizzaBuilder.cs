namespace BuilderPattern
{
    internal interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();

        Pizza GetPizza();
    }
}
