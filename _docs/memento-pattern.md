## Overview
The Memento Pattern provides a way to capture and store the internal state of an object without violating encapsulation, so the object can be restored to this state later.

## Participants
- **Memento**: Stores the internal state of the Originator object.
- **Originator**: Creates a Memento containing its current state and uses it to restore its state.
- **Caretaker**: Requests a Memento from the Originator and stores it for future use.

## Use Cases
- Implementing undo/redo functionality in applications.
- Saving and restoring game states.

## Advantages
- Preserves encapsulation by storing the internal state externally.
- Simplifies state restoration processes.
- Can be implemented with minimal impact on existing code.

## UML Diagram

![Memento Pattern UML](diagramMementoPattern.png)