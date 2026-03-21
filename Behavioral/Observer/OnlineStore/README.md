**Task:** After placing an order, the system directly triggers several side effects: sending an email, updating statistics, and saving an audit log. Refactor the code so that `OrderService` does not depend directly on all actions executed after placing an order.

```csharp
public class Order
{
    public string CustomerEmail { get; }
    public decimal Total { get; }

    public Order(string customerEmail, decimal total)
    {
        CustomerEmail = customerEmail;
        Total = total;
    }
}

public class EmailService
{
    public void SendOrderConfirmation(string email)
    {
        Console.WriteLine($"Wysłano potwierdzenie zamówienia do: {email}");
    }
}

public class StatisticsService
{
    public void UpdateAfterOrder(Order order)
    {
        Console.WriteLine($"Zaktualizowano statystyki sprzedaży: {order.Total}");
    }
}

public class AuditLogService
{
    public void Save(string message)
    {
        Console.WriteLine($"AUDYT: {message}");
    }
}

public class OrderService
{
    private readonly EmailService _emailService = new EmailService();
    private readonly StatisticsService _statisticsService = new StatisticsService();
    private readonly AuditLogService _auditLogService = new AuditLogService();

    public void PlaceOrder(Order order)
    {
        Console.WriteLine("Zamówienie zapisane w bazie.");

        _emailService.SendOrderConfirmation(order.CustomerEmail);
        _statisticsService.UpdateAfterOrder(order);
        _auditLogService.Save($"Nowe zamówienie dla klienta: {order.CustomerEmail}");
    }
}

public class Program
{
    public static void Main()
    {
        var orderService = new OrderService();
        orderService.PlaceOrder(new Order("anna@example.com", 249.99m));
    }
}
```
