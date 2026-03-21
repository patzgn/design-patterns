namespace OnlineStore.Events;

public class StatisticsService
{
    public void OnOrderPlaced(object? sender, OrderPlacedEventArgs e)
    {
        UpdateAfterOrder(e.Total);
    }

    private void UpdateAfterOrder(decimal total)
    {
        Console.WriteLine($"Zaktualizowano statystyki sprzedaży: {total}");
    }
}
