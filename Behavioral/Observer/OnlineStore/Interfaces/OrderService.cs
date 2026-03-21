namespace OnlineStore.Interfaces;

public class OrderService
{
    private readonly List<IObserver> _observers = [];

    public void Subscribe(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void Unsubscribe(IObserver observer)
    {
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer);
        }
    }

    public void Publish(Order order)
    {
        _observers.ForEach(x => x.Update(order));
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine("Zamówienie zapisane w bazie.");

        Publish(order);
    }
}
