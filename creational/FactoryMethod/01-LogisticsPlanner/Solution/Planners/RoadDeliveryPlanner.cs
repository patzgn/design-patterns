using LogisticsPlanner.Solution.Transports;

namespace LogisticsPlanner.Solution.Planners;

public class RoadDeliveryPlanner : DeliveryPlanner
{
    protected override ITransport CreateTransport()
    {
        return new Truck();
    }
}
