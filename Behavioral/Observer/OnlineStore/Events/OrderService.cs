namespace OnlineStore.Events;

public class OrderService
{
    public event EventHandler<OrderPlacedEventArgs>? OrderPlaced;

    public void PlaceOrder(Order order)
    {
        Console.WriteLine("Zamówienie zapisane w bazie.");

        OrderPlaced?.Invoke(this, new OrderPlacedEventArgs
        {
            CustomerEmail = order.CustomerEmail,
            Total = order.Total,
        });
    }
}
