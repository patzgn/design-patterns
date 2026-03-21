namespace OnlineStore.Events;

public class AuditLogService
{
    public void OnOrderPlaced(object? sender, OrderPlacedEventArgs e)
    {
        Save($"Nowe zamówienie dla klienta: {e.CustomerEmail}");
    }

    private void Save(string message)
    {
        Console.WriteLine($"AUDYT: {message}");
    }
}
