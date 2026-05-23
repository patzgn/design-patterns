namespace LogisticsPlanner.Solution.Transports;

public class Drone : ITransport
{
    public string Name { get; }
    public int CapacityKg { get; }
    public string StartLocation { get; }

    public Drone()
    {
        Name = "Drone";
        CapacityKg = 12;
        StartLocation = "roof landing zone";
    }
}
