namespace LogisticsPlanner.Solution.Transports;

public class Ship : ITransport
{
    public string Name { get; }
    public int CapacityKg { get; }
    public string StartLocation { get; }

    public Ship()
    {
        Name = "Ship";
        CapacityKg = 4_000;
        StartLocation = "harbor terminal";
    }
}
