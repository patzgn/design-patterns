namespace Conceptual;

public class Product
{
    private readonly List<object> _parts = [];

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        var parts = string.Join(", ", _parts);

        return $"Product parts: {parts} \n";
    }
}
