using ShapeLibrary.Shapes;

namespace ShapeLibrary.Services
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
