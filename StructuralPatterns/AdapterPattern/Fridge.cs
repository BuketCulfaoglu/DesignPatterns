namespace AdapterPattern
{
    internal class Fridge : IElectricalDevice
    {
        private readonly int _voltage;

        public Fridge()
        {
            _voltage = 220;
        }

        public int PlugInAndTurnOn()
        {
            Console.WriteLine("Fridge Turned On..");
            return _voltage;
        }
    }
}
