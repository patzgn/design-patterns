// See https://aka.ms/new-console-template for more information

using Conceptual;

var builder = new ConcreteBuilder();
var director = new Director(builder);

director.BuildMinimalViableProduct();
var basicProduct = builder.GetProduct();
Console.WriteLine("Standard basic product:");
Console.WriteLine(basicProduct.ListParts());

director.BuildFullFeaturedProduct();
var fullFeaturedProduct = builder.GetProduct();
Console.WriteLine("Standard full featured product:");
Console.WriteLine(fullFeaturedProduct.ListParts());


var customBuilder = new ConcreteBuilder();
var customProduct = customBuilder
    .BuildPartA()
    .BuildPartC()
    .GetProduct();

Console.WriteLine("Custom product:");
Console.WriteLine(customProduct.ListParts());
