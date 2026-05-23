namespace LogisticsPlanner.Solution.Transports;

public interface ITransport
{
    string Name { get; }
    int CapacityKg { get; }
    string StartLocation { get; }
}
