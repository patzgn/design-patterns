using ShapeAndColor.Colors;
using ShapeAndColor.Shapes;

var red = new Red();
var green = new Green();

var redCircle = new Circle(red);
var greenRectangle = new Rectangle(green);

Console.WriteLine(redCircle.Draw());
Console.WriteLine(greenRectangle.Draw());
