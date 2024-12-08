namespace Conceptual;

public class Address : ICloneable
{
    public required string Street { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
