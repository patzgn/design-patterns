namespace OnlineStore.Interfaces;

public class StatisticsService : IObserver
{
    public void Update(Order order)
    {
        UpdateAfterOrder(order);
    }

    private void UpdateAfterOrder(Order order)
    {
        Console.WriteLine($"Zaktualizowano statystyki sprzedaży: {order.Total}");
    }
}
