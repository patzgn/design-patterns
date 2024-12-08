// See https://aka.ms/new-console-template for more information

using CarBuilder;

var carBuilder = new CarBuilder.CarBuilder();
var carDirector = new CarDirector();

var sportsCar = carDirector.ConstructSportCar(carBuilder);
Console.WriteLine(sportsCar);

var customCar = new CarBuilder.CarBuilder()
    .SetEngine("Custom engine")
    .SetWheels("Custom wheels")
    .SetInterior("Custom interior")
    .Build();
Console.WriteLine(customCar);
