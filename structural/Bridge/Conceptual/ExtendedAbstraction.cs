namespace Conceptual;

/// <summary>
/// You can extend the Abstraction without changing the Implementation classes.
/// </summary>
public class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
               implementation.OperationImplementation();
    }
}
