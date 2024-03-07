using ShapeAreaCalc.Shapes;

namespace ShapeAreaCalc
{
    public class AreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            if (shape is null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            return shape.CalculateArea();
        }
    }
}
