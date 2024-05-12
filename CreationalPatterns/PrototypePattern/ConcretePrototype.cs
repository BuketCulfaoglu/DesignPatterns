using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class ConcretePrototype : ICloneablePrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ConcretePrototype(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ICloneablePrototype Clone()
        {
            return (ICloneablePrototype)MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Prototype : Id={Id}, Name={Name}");
        }
    }
}
