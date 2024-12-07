namespace Conceptual;

public class Director(IBuilder builder)
{
    private IBuilder _builder = builder;

    public IBuilder Builder
    {
        set => _builder = value;
    }

    public void BuildMinimalViableProduct()
    {
        _builder.Reset()
            .BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        _builder.Reset()
            .BuildPartA()
            .BuildPartB()
            .BuildPartC();
    }
}
