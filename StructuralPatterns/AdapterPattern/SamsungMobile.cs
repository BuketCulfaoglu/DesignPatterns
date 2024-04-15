namespace AdapterPattern
{
    internal class SamsungMobile : IMobile
    {
        private int _voltage;

        public SamsungMobile()
        {
            _voltage = 5;
        }

        public int Charge()
        {
            Console.WriteLine("Samsung mobile charging..");
            return _voltage;
        }
    }
}
