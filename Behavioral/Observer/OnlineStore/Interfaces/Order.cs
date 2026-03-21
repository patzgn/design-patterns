namespace OnlineStore.Interfaces;

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
