namespace SupportTicketRouter.Solution.Handlers;

public interface ITicketHandler
{
    string Assign(SupportTicket ticket);

    string CreateFirstResponse(SupportTicket ticket);
}
