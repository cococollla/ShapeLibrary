using ShapeLibrary.Services;
using ShapeLibrary.Shapes;
using Xunit;

namespace ShapeLibrary.Tests.tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.CalculateArea();

            Assert.Equal(Math.PI * radius * radius, area, 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            double sideA = 3, sideB = 4, sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void RightTriangleCheckTest()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle notRightTriangle = new Triangle(3, 4, 6);

            Assert.True(rightTriangle.IsRightTriangle());
            Assert.False(notRightTriangle.IsRightTriangle());
        }

        [Fact]
        public void AreaCalculatorTest()
        {
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);
            AreaCalculator calculator = new AreaCalculator();

            double circleArea = calculator.CalculateArea(circle);
            double triangleArea = calculator.CalculateArea(triangle);

            Assert.Equal(Math.PI * 5 * 5, circleArea, 5);
            Assert.Equal(6, triangleArea, 5);
        }
    }
}
