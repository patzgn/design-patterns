## Logger Exercise

### Goal:
Create an implementation of the **Adapter** design pattern to adapt the `ExternalLogger` class to the `ILogger` interface.

### Description:

1. **Interface `ILogger`:**
   - Represents the expected logging interface in the system.
   - Contains a method `Log(string message)`.

2. **Class `ExternalLogger`:**
   - An existing class with the method `LogMessage(string message)`.
   - Does not conform to the `ILogger` interface.

3. **Adapter Class:**
   - Implements the `ILogger` interface.
   - Internally uses an `ExternalLogger` object to call `LogMessage`.

### Objective:
Understand how the Adapter pattern allows integrating existing classes with new interfaces without modifying their code.
