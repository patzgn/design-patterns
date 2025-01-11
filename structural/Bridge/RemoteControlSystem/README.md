## Remote Control System Exercise

### Goal:
Create an implementation of the **Bridge** design pattern to separate the abstraction of remote controls from the implementation of devices.

### Description:

1. **Interface `IDevice`:**
   - Represents the device implementation in the system.
   - Contains methods:
     - `TurnOn()`
     - `TurnOff()`
     - `SetVolume(int volume)`

2. **Concrete Classes Implementing `IDevice`:**
   - **`TV`** and **`Radio`**:
     - Implement the `IDevice` interface.
     - Provide specific functionality for turning on/off and setting the volume.

3. **Abstract Class `Remote`:**
   - Serves as the abstraction in the Bridge pattern.
   - Contains a reference to an `IDevice` object.
   - Provides basic methods to control the device.

4. **Refined Abstraction Classes (`Remote` subclasses):**
   - **`BasicRemote`**:
     - Provides basic functionality such as turning the device on/off and adjusting the volume.
   - **`AdvancedRemote`**:
     - Extends `Remote` with additional functionality, such as muting the device.

### Objective:
Understand how the Bridge pattern allows abstraction (`Remote`) and implementation (`IDevice`) to evolve independently, enabling flexibility and scalability in system design.
