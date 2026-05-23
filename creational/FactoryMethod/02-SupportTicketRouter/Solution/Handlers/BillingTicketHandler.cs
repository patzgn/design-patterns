namespace SupportTicketRouter.Solution.Handlers;

public class BillingTicketHandler : ITicketHandler
{
    public string Assign(SupportTicket ticket) => "Assigned to the billing queue";

    public string CreateFirstResponse(SupportTicket ticket) => "A billing specialist will review the invoice details.";
}
