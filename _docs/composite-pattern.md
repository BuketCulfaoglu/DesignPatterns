## Overview
The Composite Pattern composes objects into tree structures to represent part-whole hierarchies, allowing clients to treat individual objects and compositions uniformly.

## Participants
- **Component**: Defines the interface for all objects in the composition.
- **Leaf**: Represents leaf objects in the composition, which have no children.
- **Composite**: Holds child components and implements child-related operations.

## Use Cases
- Representing part-whole hierarchies in structures like file systems.
- Constructing complex user interfaces.
- Enabling unified access to both individual objects and composite structures.

## Advantages
- Simplifies client code by allowing uniform treatment of composite and individual objects.
- Encourages the creation of hierarchical structures.
- Reduces the need for conditional checks for leaf or composite classes.

## UML Diagram

![Composite Pattern UML](diagramCompositePattern.png)