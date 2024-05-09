namespace AbstractFactoryPattern
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
