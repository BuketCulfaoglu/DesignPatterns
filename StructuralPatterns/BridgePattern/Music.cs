using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Music
    {
        private string _name;
        private string _sound;

        public Music(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name { get => _name; set => _name = value; }
        public string Sound { get => _sound; set => _sound = value; }

        public override string ToString()
        {
            return Name;
        }

    }
}
