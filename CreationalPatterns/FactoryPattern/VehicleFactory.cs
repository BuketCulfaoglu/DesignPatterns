namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "car": return new Car();
                case "truck": return new Truck();
                default: throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
