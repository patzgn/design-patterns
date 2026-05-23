using SupportTicketRouter.Solution.Handlers;

namespace SupportTicketRouter.Solution.Routers;

public abstract class TicketRouter
{
    public string Route(SupportTicket ticket)
    {
        var handler = CreateTicketHandler();

        var assignment = handler.Assign(ticket);
        var firstResponse = handler.CreateFirstResponse(ticket);

        return $"{ticket.Id}: {assignment}. First response: {firstResponse}";
    }

    protected abstract ITicketHandler CreateTicketHandler();
}
