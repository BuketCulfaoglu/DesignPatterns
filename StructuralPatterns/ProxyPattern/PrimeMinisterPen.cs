namespace ProxyPattern
{
    internal class PrimeMinisterPen
    {
        private readonly IPrimeMinister _primeMinister;

        public PrimeMinisterPen(IPrimeMinister primeMinister)
        {
            _primeMinister = new PrimeMinisterProxy(primeMinister);
        }

        public IPrimeMinister GetPrimeMinister()
        {
            Console.WriteLine($"Prime Minister is available now.. ");
            return _primeMinister;
        }
    }
}
