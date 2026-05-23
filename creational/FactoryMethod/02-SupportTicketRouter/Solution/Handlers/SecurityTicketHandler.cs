namespace SupportTicketRouter.Solution.Handlers;

public class SecurityTicketHandler : ITicketHandler
{
    public string Assign(SupportTicket ticket) => "Assigned to the security incident queue";

    public string CreateFirstResponse(SupportTicket ticket) =>
        "We locked suspicious sessions while the incident is reviewed.";
}
