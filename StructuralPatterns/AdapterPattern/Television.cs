using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Television : IElectricalDevice
    {
        private readonly int _voltage;

        public Television()
        {
            _voltage = 220;
        }

        public int PlugInAndTurnOn()
        {
            Console.WriteLine("Television Turned On..");
            return _voltage;
        }
    }
}
