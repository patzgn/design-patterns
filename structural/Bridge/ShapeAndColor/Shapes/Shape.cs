using ShapeAndColor.Colors;

namespace ShapeAndColor.Shapes;

public abstract class Shape(IColor color)
{
    public abstract string Draw();
}
