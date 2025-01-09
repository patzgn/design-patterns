### Definition

The Adapter pattern is a design pattern that enables two incompatible interfaces to work together by creating an intermediary class. It is often used in scenarios such as:

- Legacy code that does not fit new requirements.
- External libraries with interfaces different from what is expected in our project.

### Key Concepts

- **Target:** The interface or class we want to work with.
- **Adaptee:** The class whose interface needs to be adapted.
- **Adapter:** The intermediary class that connects the Target with the Adaptee.

### Classification of the Adapter Pattern

The Adapter pattern can be implemented in two variations:

- **Class Adapter (Inheritance):**
    - Works through inheritance (requires support for multiple inheritance, e.g., in C++).
    - Less commonly used in C# due to the lack of multiple inheritance.

- **Object Adapter (Composition):**
    - Utilizes composition to connect the Adaptee object with the Target interface.
    - More flexible and widely used in C#.

### Examples of Adapter Usage

- **Integration with external APIs:**
    
    Example: Adapting the interface of an external payment system to fit the internal order management system.

- **Data format conversion:**

    Example: Adapting data in JSON format to match the expected model in the application.

- **Handling legacy code:**

    Example: In a new system, using an old class whose interface differs from the current requirements.