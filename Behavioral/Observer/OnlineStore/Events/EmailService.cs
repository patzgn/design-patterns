namespace OnlineStore.Events;

public class EmailService
{
    public void OnOrderPlaced(object? sender, OrderPlacedEventArgs e)
    {
        SendOrderConfirmation(e.CustomerEmail);
    }

    private void SendOrderConfirmation(string email)
    {
        Console.WriteLine($"Wysłano potwierdzenie zamówienia do: {email}");
    }
}
