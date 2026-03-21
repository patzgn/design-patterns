namespace OnlineStore.Events;

public static class Test
{
    public static void Run()
    {
        Console.WriteLine("Testing events");

        var orderService = new OrderService();

        var emailService = new EmailService();
        var statisticsService = new StatisticsService();
        var auditLogService = new AuditLogService();

        orderService.OrderPlaced += emailService.OnOrderPlaced;
        orderService.OrderPlaced += statisticsService.OnOrderPlaced;
        orderService.OrderPlaced += auditLogService.OnOrderPlaced;

        orderService.PlaceOrder(new Order("anna@example.com", 249.99m));

        orderService.OrderPlaced -= emailService.OnOrderPlaced;
        orderService.OrderPlaced -= statisticsService.OnOrderPlaced;
        orderService.OrderPlaced -= auditLogService.OnOrderPlaced;

        orderService.PlaceOrder(new Order("anna@example.com", 249.99m));
    }
}
