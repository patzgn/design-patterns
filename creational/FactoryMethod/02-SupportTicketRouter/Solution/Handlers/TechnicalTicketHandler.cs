namespace SupportTicketRouter.Solution.Handlers;

public class TechnicalTicketHandler : ITicketHandler
{
    public string Assign(SupportTicket ticket) => "Assigned to the product support queue";

    public string CreateFirstResponse(SupportTicket ticket) =>
        "Please attach device logs and the exact time of the crash.";
}
