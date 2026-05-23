using LogisticsPlanner.Solution.Transports;

namespace LogisticsPlanner.Solution.Planners;

public class SeaDeliveryPlanner : DeliveryPlanner
{
    protected override ITransport CreateTransport()
    {
        return new Ship();
    }
}
