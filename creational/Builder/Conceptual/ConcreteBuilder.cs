namespace Conceptual;

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public IBuilder Reset()
    {
        _product = new Product();
        return this;
    }

    public IBuilder BuildPartA()
    {
        _product.Add("PartA1");
        return this;
    }

    public IBuilder BuildPartB()
    {
        _product.Add("PartB1");
        return this;
    }

    public IBuilder BuildPartC()
    {
        _product.Add("PartC1");
        return this;
    }

    public Product GetProduct()
    {
        return _product;
    }
}
