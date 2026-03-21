namespace OnlineStore.Interfaces;

public class EmailService : IObserver
{
    public void Update(Order order)
    {
        SendOrderConfirmation(order.CustomerEmail);
    }

    private void SendOrderConfirmation(string email)
    {
        Console.WriteLine($"Wysłano potwierdzenie zamówienia do: {email}");
    }
}
