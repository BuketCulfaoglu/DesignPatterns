namespace ProxyPattern
{
    internal class PrimeMinisterProxy : IPrimeMinister
    {

        private readonly IPrimeMinister _primeMinisterReal;

        public PrimeMinisterProxy(IPrimeMinister primeMinisterReal)
        {
            _primeMinisterReal = primeMinisterReal;
        }

        public void FindJob(string jobName)
        {
            Console.WriteLine($"Proxy PM : You are a {jobName} than..");
        }

        public bool ListenProblem(string name, string problem)
        {
            Console.WriteLine($"Proxy PM : {name}! I'm Listening.. Talking about {problem}.. Right? ");
            bool isUrgent = problem.Length % 2 == 1;

            if (isUrgent)
            {
                ForwardMessage(name, problem);
                return true;
            }

            Console.WriteLine($"Proxy PM : {problem} is not urgent {name}!");
            return false;
        }

        private void ForwardMessage(string message, string problem)
        {
            _primeMinisterReal.ListenProblem(message, problem);
        }
    }
}
