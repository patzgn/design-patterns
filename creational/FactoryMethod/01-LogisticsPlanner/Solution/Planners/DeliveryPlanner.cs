using LogisticsPlanner.Solution.Transports;

namespace LogisticsPlanner.Solution.Planners;

public abstract class DeliveryPlanner
{
    public string PlanDelivery(string orderNumber)
    {
        var transport = CreateTransport();

        return $"{orderNumber}: {transport.Name} can deliver up to {transport.CapacityKg} kg " +
            $"from the {transport.StartLocation}.";
    }

    protected abstract ITransport CreateTransport();
}
