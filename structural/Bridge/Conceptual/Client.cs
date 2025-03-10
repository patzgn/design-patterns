namespace Conceptual;

/// <summary>
/// Except for the initialization phase, where an Abstraction object gets
/// linked with a specific Implementation object, the client code should
/// only depend on the Abstraction class. This way the client code can
/// support any abstraction-implementation combination.
/// </summary>
public class Client
{
    public void ClientCode(Abstraction abstraction)
    {
        Console.Write(abstraction.Operation());
    }
}
