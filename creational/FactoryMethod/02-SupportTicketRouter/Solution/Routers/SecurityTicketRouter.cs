using SupportTicketRouter.Solution.Handlers;

namespace SupportTicketRouter.Solution.Routers;

public class SecurityTicketRouter : TicketRouter
{
    protected override ITicketHandler CreateTicketHandler()
    {
        return new SecurityTicketHandler();
    }
}
