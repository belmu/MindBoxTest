namespace ShapeAreaCalc.Shapes
{
    public class Circle(double radius) : IShape
    {
        public double Radius { get; } = radius > 0 ? radius : throw new ArgumentOutOfRangeException(nameof(radius));

        public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
