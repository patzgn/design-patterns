using Conceptual;

var adaptee = new Adaptee();

var target = new Adapter(adaptee);

target.Request();
