# DesignPatterns



## Structural Patterns
- **Adapter Pattern:** Allows objects with incompatible interfaces to collaborate.
- **Bridge Pattern:** Decouples an abstraction from its implementation so that the two can vary independently.
- **Composite Pattern:** Composes objects into tree structures to represent part-whole hierarchies.
- **Decorator Pattern:** Attaches additional responsibilities to an object dynamically.
- **Facade Pattern:** Provides a unified interface to a set of interfaces in a subsystem.
- **Proxy Pattern:** Provides a surrogate or placeholder for another object to control access to it.

## Creational Patterns
- **Singleton Pattern:** Ensures that a class has only one instance and provides a global point of access to that instance.
- **Factory Method Pattern:** Defines an interface for creating an object, but allows subclasses to alter the type of objects that will be created.
- **Abstract Factory Pattern:** Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- **Builder Pattern:** Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
- **Prototype Pattern:** Creates new objects by copying an existing object, known as a prototype, during runtime.

## Behavioral Patterns
- **Observer Pattern:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
- **Strategy Pattern:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
- **Command Pattern:** Encapsulates a request as an object, thereby allowing for parameterization of clients with queues, requests, and operations.
- **Chain of Responsibility Pattern:** Passes requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.
- **Iterator Pattern:** Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
- **Visitor Pattern:** Represents an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.