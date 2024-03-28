namespace AdapterPattern
{
    internal class MobileElectricalDeviceAdapter : IElectricalDevice
    {
        private readonly IMobile _mobile;

        public MobileElectricalDeviceAdapter(IMobile mobile)
        {
            _mobile = mobile;
        }

        public int PlugInAndTurnOn()
        {
            return _mobile.Charge();
        }
    }
}
