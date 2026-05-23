using SupportTicketRouter.Solution.Handlers;

namespace SupportTicketRouter.Solution.Routers;

public class BillingTicketRouter : TicketRouter
{
    protected override ITicketHandler CreateTicketHandler()
    {
        return new BillingTicketHandler();
    }
}
