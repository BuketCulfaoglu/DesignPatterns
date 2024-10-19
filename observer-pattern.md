# Observer Pattern

The **Observer Pattern** is a behavioral design pattern that defines a one-to-many dependency between objects, so when one object changes state, all its dependents (**observers**) are notified and updated automatically.

## Key Concepts

- **Subject**: The object being observed. It maintains a list of observers, facilitates adding/removing observers, and notifies them of any state changes.
- **Observer**: An object that watches the subject. It is updated automatically when the subject’s state changes.

## Use Cases

- Event handling systems
- Implementing distributed systems where multiple components need to be aware of state changes
- User interface components, where one change affects others
- Real-time systems such as stock market updates

## Structure

1. **Subject Interface**: 
   - Maintains a list of observers
   - Methods for attaching, detaching, and notifying observers
   
2. **Concrete Subject**: 
   - Implements the subject interface
   - Notifies observers of state changes
   
3. **Observer Interface**: 
   - Declares a method for updating the observer based on subject state
   
4. **Concrete Observer**: 
   - Implements the observer interface
   - Updates its state in response to subject changes

## UML Diagram

![Observer Pattern UML](diagramObserverPattern.png)