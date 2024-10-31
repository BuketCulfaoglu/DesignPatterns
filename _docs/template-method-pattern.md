## Overview
The Template Method Pattern defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.

## Participants
- **AbstractClass**: Defines the template method, which outlines the steps of the algorithm, and provides default implementations of some steps.
- **ConcreteClass**: Implements the specific steps of the algorithm that the AbstractClass defines.

## Use Cases
- Implementing algorithms that follow a common structure but require customization in specific steps.
- Defining workflows where certain steps are handled differently depending on the situation.

## Advantages
- Promotes code reuse by defining a standard structure for algorithms.
- Simplifies the addition of new behaviors without altering the algorithm's skeleton.
- Fosters consistency across similar processes.

## UML Diagram

![Template Method Pattern UML](diagramTemplateMethodPattern.png)