var planner = new DeliveryPlanner();

foreach (var mode in new[] { "road", "sea", "air" })
{
    Console.WriteLine(planner.PlanDelivery(mode, "Order-1042"));
}

public sealed class DeliveryPlanner
{
    public string PlanDelivery(string mode, string orderNumber)
    {
        var transport = mode switch
        {
            "road" => new Transport("Truck", 900, "loading dock"),
            "sea" => new Transport("Ship", 4_000, "harbor terminal"),
            "air" => new Transport("Drone", 12, "roof landing zone"),
            _ => throw new ArgumentException($"Unsupported delivery mode: {mode}")
        };

        return $"{orderNumber}: {transport.Name} can deliver up to {transport.CapacityKg} kg " +
            $"from the {transport.StartLocation}.";
    }
}

public sealed record Transport(string Name, int CapacityKg, string StartLocation);
