namespace CarBuilder;

public class Car
{
    public string? Engine { get; set; }
    public string? Wheels { get; set; }
    public string? Interior { get; set; }

    public override string ToString()
    {
        return $"Car with {Engine} engine, {Wheels} wheels and {Interior} interior";
    }
}
