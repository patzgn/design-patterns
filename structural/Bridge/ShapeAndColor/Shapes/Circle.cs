using ShapeAndColor.Colors;

namespace ShapeAndColor.Shapes;

public class Circle : Shape
{
    private readonly IColor _color;

    public Circle(IColor color) : base(color)
    {
        _color = color;
    }

    public override string Draw()
    {
        return $"Drawing a Circle in {_color.ApplyColor()} color.";
    }
}
