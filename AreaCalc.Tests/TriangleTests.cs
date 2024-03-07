using ShapeAreaCalc.Shapes;

namespace AreaCalc.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void ShouldThrowIfIncorrectTriangleSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, -5));
        }

        [Fact]
        public void ShouldThrowIfIncorrectTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(100, 2, 3));
        }

        [Fact]
        public void ShouldCheckRightTriangle()
        {
            var rightT = new Triangle(24, 26, 10);
            Assert.True(rightT.IsRight());

            var nonRight = new Triangle(24, 26, 13);
            Assert.False(nonRight.IsRight());
        }

        [Fact]
        public void ShouldCalculateArea()
        {
            var t = new Triangle(24, 26, 10);
            var area = t.CalculateArea();
            Assert.Equal(120, area);
        }
    }
}
