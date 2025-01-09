// See https://aka.ms/new-console-template for more information

using Conceptual;

var adaptee = new Adaptee();

var target = new Adapter(adaptee);

target.Request();
