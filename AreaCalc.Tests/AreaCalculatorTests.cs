using ShapeAreaCalc;
using ShapeAreaCalc.Shapes;

namespace AreaCalc.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void ShouldCalculateCircleArea()
        {
            var c = new Circle(42);
            var area = AreaCalculator.CalculateArea(c);

            Assert.Equal(area, c.CalculateArea());
        }

        [Fact]
        public void ShouldCalculateTriangleArea()
        {
            var t = new Triangle(10, 10, 10);
            var area = AreaCalculator.CalculateArea(t);

            Assert.Equal(area, t.CalculateArea());
        }
    }
}