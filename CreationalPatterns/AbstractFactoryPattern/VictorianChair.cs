namespace AbstractFactoryPattern
{
    internal class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a victorian chair");
        }
    }
}
