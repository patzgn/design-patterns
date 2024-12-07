namespace Conceptual;

public interface IBuilder
{
    IBuilder BuildPartA();
    IBuilder BuildPartB();
    IBuilder BuildPartC();
    
    Product GetProduct();

    IBuilder Reset();
}
