using SupportTicketRouter.Solution.Handlers;

namespace SupportTicketRouter.Solution.Routers;

public class TechnicalTicketRouter : TicketRouter
{
    protected override ITicketHandler CreateTicketHandler()
    {
        return new TechnicalTicketHandler();
    }
}
