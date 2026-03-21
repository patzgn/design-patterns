namespace OnlineStore.Events;

public class OrderPlacedEventArgs : EventArgs
{
    public required string CustomerEmail { get; set; }
    public required decimal Total { get; set; }
}
