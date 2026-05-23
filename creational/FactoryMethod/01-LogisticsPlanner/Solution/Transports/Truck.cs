namespace LogisticsPlanner.Solution.Transports;

public class Truck : ITransport
{
    public string Name { get; }
    public int CapacityKg { get; }
    public string StartLocation { get; }

    public Truck()
    {
        Name = "Truck";
        CapacityKg = 900;
        StartLocation = "loading dock";
    }
}
