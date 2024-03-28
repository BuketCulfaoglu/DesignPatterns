namespace AdapterPattern
{
    internal class ElectricSocket
    {
        public void GiveElectricty(IElectricalDevice electricalDevice)
        {
            int volt = electricalDevice.PlugInAndTurnOn();
            Console.WriteLine($"Taking {volt} volts from the socket..");
        }
    }
}
