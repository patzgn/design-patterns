namespace OnlineStore.Interfaces;

public static class Test
{
    public static void Run()
    {
        Console.WriteLine("Testing custom interface");

        var orderService = new OrderService();

        var emailService = new EmailService();
        var statisticsService = new StatisticsService();
        var auditLogService = new AuditLogService();

        orderService.Subscribe(emailService);
        orderService.Subscribe(statisticsService);
        orderService.Subscribe(auditLogService);

        orderService.PlaceOrder(new Order("anna@example.com", 249.99m));

        orderService.Unsubscribe(emailService);
        orderService.Unsubscribe(statisticsService);
        orderService.Unsubscribe(auditLogService);

        orderService.PlaceOrder(new Order("anna@example.com", 249.99m));
    }
}
