using ShapeAndColor.Colors;

namespace ShapeAndColor.Shapes;

public class Rectangle : Shape
{
    private readonly IColor _color;

    public Rectangle(IColor color) : base(color)
    {
        _color = color;
    }

    public override string Draw()
    {
        return $"Drawing a Rectangle in {_color.ApplyColor()} color.";
    }
}
