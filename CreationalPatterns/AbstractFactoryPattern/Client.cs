namespace AbstractFactoryPattern
{
    internal class Client
    {
        private readonly IFurnitureFactory _factory;

        public Client(IFurnitureFactory factory)
        {
            _factory = factory;
        }

        public void SitAndRelax()
        {
            IChair chair = _factory.CreateChair();
            ISofa sofa = _factory.CreateSofa();

            chair.SitOn();
            sofa.RelaxOn();
        }
    }
}
