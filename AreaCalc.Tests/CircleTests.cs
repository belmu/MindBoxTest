using ShapeAreaCalc.Shapes;

namespace AreaCalc.Tests
{
    public class CircleTests
    {
        [Fact]
        public void ShouldThrowIfIncorrectCircle()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-4));
        }

        [Fact]
        public void ShouldCalculateArea()
        {
            var c = new Circle(7);
            var area = c.CalculateArea();
            Assert.Equal(153.93804002589985, area);
        }
    }
}
