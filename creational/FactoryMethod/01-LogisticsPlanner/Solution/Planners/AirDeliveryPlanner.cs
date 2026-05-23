using LogisticsPlanner.Solution.Transports;

namespace LogisticsPlanner.Solution.Planners;

public class AirDeliveryPlanner : DeliveryPlanner
{
    protected override ITransport CreateTransport()
    {
        return new Drone();
    }
}
