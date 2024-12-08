namespace CarBuilder;

public class CarDirector
{
    public Car ConstructSportCar(CarBuilder builder)
    {
        return builder.SetEngine("V8")
            .SetWheels("Sports wheels")
            .SetInterior("Leather")
            .Build();
    }
}
