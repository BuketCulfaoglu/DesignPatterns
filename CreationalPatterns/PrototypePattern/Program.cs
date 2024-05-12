using PrototypePattern;

ConcretePrototype prototype = new ConcretePrototype(1, "Prototype");

ConcretePrototype clone1 = (ConcretePrototype)prototype.Clone();
clone1.Name = "Clone 1";

prototype.Display();
clone1.Display();

ConcretePrototype clone2 = (ConcretePrototype)prototype.Clone();
clone2.Name = "Clone 2";

clone2.Display();