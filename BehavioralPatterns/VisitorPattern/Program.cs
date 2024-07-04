using VisitorPattern;

ObjectStructure objectStructure = new ObjectStructure();

objectStructure.Attach(new ElementA());
objectStructure.Attach(new ElementB());

ConcreteVisitor visitor = new ConcreteVisitor();

objectStructure.Accept(visitor);