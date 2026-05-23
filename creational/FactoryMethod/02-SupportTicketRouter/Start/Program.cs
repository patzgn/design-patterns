var tickets = new[]
{
    new SupportTicket("T-1001", "billing", "Invoice amount is incorrect"),
    new SupportTicket("T-1002", "technical", "The mobile app crashes after login"),
    new SupportTicket("T-1003", "security", "Suspicious sign-in from another country")
};

var router = new TicketRouter();

foreach (var ticket in tickets)
{
    Console.WriteLine(router.Route(ticket));
}

public sealed class TicketRouter
{
    public string Route(SupportTicket ticket)
    {
        ITicketHandler handler = ticket.Category switch
        {
            "billing" => new BillingTicketHandler(),
            "technical" => new TechnicalTicketHandler(),
            "security" => new SecurityTicketHandler(),
            _ => throw new ArgumentException($"Unsupported ticket category: {ticket.Category}")
        };

        var assignment = handler.Assign(ticket);
        var firstResponse = handler.CreateFirstResponse(ticket);

        return $"{ticket.Id}: {assignment}. First response: {firstResponse}";
    }
}

public sealed record SupportTicket(string Id, string Category, string Description);

public interface ITicketHandler
{
    string Assign(SupportTicket ticket);

    string CreateFirstResponse(SupportTicket ticket);
}

public sealed class BillingTicketHandler : ITicketHandler
{
    public string Assign(SupportTicket ticket) => "Assigned to the billing queue";

    public string CreateFirstResponse(SupportTicket ticket) => "A billing specialist will review the invoice details.";
}

public sealed class TechnicalTicketHandler : ITicketHandler
{
    public string Assign(SupportTicket ticket) => "Assigned to the product support queue";

    public string CreateFirstResponse(SupportTicket ticket) => "Please attach device logs and the exact time of the crash.";
}

public sealed class SecurityTicketHandler : ITicketHandler
{
    public string Assign(SupportTicket ticket) => "Assigned to the security incident queue";

    public string CreateFirstResponse(SupportTicket ticket) => "We locked suspicious sessions while the incident is reviewed.";
}

