using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Citizen
    {
        private readonly IPrimeMinister _primeMinister;

        public Citizen(PrimeMinisterPen primeMinisterPen)
        {
            _primeMinister = primeMinisterPen.GetPrimeMinister();
        }

        public string TellIssue(string name, string issue)
        {
            return _primeMinister.ListenProblem(name, issue) ? $"{name} : OK" : $"{name} : Not good at all..";
        }

        public void AskForJob(string jobName)
        {
            _primeMinister.FindJob(jobName);
        }
    }
}
