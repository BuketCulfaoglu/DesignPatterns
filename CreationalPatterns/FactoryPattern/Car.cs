namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
