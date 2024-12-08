namespace CarBuilder;

public class CarBuilder
{
    private Car _car = new();

    public CarBuilder SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }

    public CarBuilder SetWheels(string wheels)
    {
        _car.Wheels = wheels;
        return this;
    }

    public CarBuilder SetInterior(string interior)
    {
        _car.Interior = interior;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}
