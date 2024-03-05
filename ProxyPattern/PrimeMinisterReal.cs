namespace ProxyPattern
{
    internal class PrimeMinisterReal : IPrimeMinister
    {
        public void FindJob(string jobName)
        {
            Console.WriteLine($"Real PM : You are a {jobName} than..");
        }

        public bool ListenProblem(string name, string problem)
        {
            Console.WriteLine($"Real PM : {name}!... We are fixing your {problem} right away.." );
            return true;
        }
    }
}
