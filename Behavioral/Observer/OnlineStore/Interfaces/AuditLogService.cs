namespace OnlineStore.Interfaces;

public class AuditLogService : IObserver
{
    public void Update(Order order)
    {
        Save($"Nowe zamówienie dla klienta: {order.CustomerEmail}");
    }

    private void Save(string message)
    {
        Console.WriteLine($"AUDYT: {message}");
    }
}
