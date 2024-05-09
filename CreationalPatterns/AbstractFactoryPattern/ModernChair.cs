namespace AbstractFactoryPattern
{
    internal class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a modern chair");
        }
    }
}
