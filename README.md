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
- **Interpreter Pattern:** Defines a grammatical representation for a language and provides an interpreter to deal with this grammar. It's used in parsing expressions, scripting languages, and communication protocols.
- **Mediator Pattern:** Defines an object that encapsulates how a set of objects interact, promoting loose coupling by keeping objects from referring to each other explicitly.
- **Memento Pattern:** Captures and externalizes an object’s internal state so that the object can be restored to this state later, without violating encapsulation. It's commonly used in implementing undo mechanisms.
- **State Pattern:** Allows an object to alter its behavior when its internal state changes, appearing as if the object changed its class. It's used in scenarios where an object’s behavior is influenced by its state, such as in state machines.
- **Template Method Pattern:** Defines the skeleton of an algorithm in a method, deferring some steps to subclasses. It allows subclasses to redefine certain steps of an algorithm without changing its structure.
- **Chain of Responsibility Pattern:** Passes requests along a chain of handlers. Each handler decides either to process the request or to pass it to the next handler in the chain.


## Table of Contents

- [Observer Pattern](_docs/observer-pattern.md)
- [Strategy Pattern](_docs/strategy-pattern.md)
- [Command Pattern](_docs/command-pattern.md)
- [Chain of Responsibility Pattern](_docs/chain-of-responsibility-pattern.md)
- [Iterator Pattern](_docs/iterator-pattern.md)
- [Visitor Pattern](_docs/visitor-pattern.md)
- [Interpreter Pattern](_docs/interpreter-pattern.md)
- [Mediator Pattern](_docs/mediator-pattern.md)
- [Memento Pattern](_docs/memento-pattern.md)
- [State Pattern](_docs/state-pattern.md)
- [Template Method Pattern](_docs/template-method-pattern.md)