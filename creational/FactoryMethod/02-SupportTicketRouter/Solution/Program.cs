using SupportTicketRouter.Solution;
using SupportTicketRouter.Solution.Routers;

var billingTicket = new SupportTicket("T-1001", "billing", "Invoice amount is incorrect");
var billingTicketRouter = new BillingTicketRouter();
Console.WriteLine(billingTicketRouter.Route(billingTicket));

var technicalTicket = new SupportTicket("T-1002", "technical", "The mobile app crashes after login");
var technicalTicketRouter = new TechnicalTicketRouter();
Console.WriteLine(technicalTicketRouter.Route(technicalTicket));

var securityTicket = new SupportTicket("T-1003", "security", "Suspicious sign-in from another country");
var securityTicketRouter = new SecurityTicketRouter();
Console.WriteLine(securityTicketRouter.Route(securityTicket));
