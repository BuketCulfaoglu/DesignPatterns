## Overview
The State Pattern allows an object to alter its behavior when its internal state changes, making the object appear to change its class.

## Participants
- **Context**: Maintains an instance of a ConcreteState that defines the current behavior.
- **State**: Declares an interface for encapsulating behavior associated with a particular state of the context.
- **ConcreteState**: Implements behavior specific to the state.

## Use Cases
- Managing the state of a document as it's drafted, reviewed, and published.
- Finite state machines like in vending machines or turnstiles.

## Advantages
- Localizes state-specific behavior.
- Simplifies the logic for state transitions.
- Encourages cohesion by keeping state-related behavior in one place.

## UML Diagram

![State Pattern UML](diagramStatePattern.png)