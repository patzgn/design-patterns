namespace Conceptual;

/// <summary>
/// The Adapter makes the Adaptee's interface compatible with the Target's interface.
/// </summary>
/// <param name="adaptee">The Adaptee object to adapt.</param>
public class Adapter(Adaptee adaptee) : ITarget
{
    public void Request()
    {
        Console.WriteLine("Adapter: I translate the call to the Adaptee.");
        adaptee.SpecificRequest();
    }
}
