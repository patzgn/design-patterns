namespace Conceptual;

public class Person : ICloneable
{
    public required IdInfo IdInfo { get; set; }
    public required string Name { get; set; }
    public int Age { get; set; }
    public List<Address> Addresses { get; set; } = [];

    public object Clone()
    {
        var clonedPerson = (Person)MemberwiseClone();

        clonedPerson.IdInfo = new IdInfo
        {
            IdNumber = IdInfo.IdNumber,
        };

        clonedPerson.Addresses = [];
        foreach (var address in Addresses)
        {
            var clonedAddress = (Address)address.Clone();

            clonedPerson.Addresses.Add(clonedAddress);
        }

        return clonedPerson;
    }
}
