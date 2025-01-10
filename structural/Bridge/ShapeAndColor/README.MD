## Shape And Color Exercise

### Goal:
Create an implementation of the **Bridge** design pattern to separate the abstraction of shapes from their color implementations.

### Description:

1. **Interface `IColor`:**
   - Represents the color implementation in the system.
   - Contains a method `ApplyColor()` that returns a string representing the color.

2. **Abstract Class `Shape`:**
   - Serves as the abstraction in the Bridge pattern.
   - Contains a reference to an `IColor` object.
   - Defines an abstract method `Draw()` to be implemented by derived classes.

3. **Concrete Classes Implementing `IColor`:**
   - **`Red`** and **`Green`**:
     - Implement the `IColor` interface.
     - Define the method `ApplyColor()` to return the specific color name.

4. **Refined Abstraction Classes (`Shape` subclasses):**
   - **`Circle`** and **`Rectangle`**:
     - Extend the `Shape` abstract class.
     - Implement the `Draw()` method to describe the shape and its color.

### Objective:
Understand how the Bridge pattern allows abstraction (`Shape`) and implementation (`IColor`) to evolve independently, enabling flexibility and extensibility in system design.
