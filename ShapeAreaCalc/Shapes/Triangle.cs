namespace ShapeAreaCalc.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = CheckParam(sideA, nameof(sideA));
            SideB = CheckParam(sideB, nameof(sideB));
            SideC = CheckParam(sideC, nameof(sideC));

            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
            {
                throw new ArgumentException("Invalid triangle");
            }

            static double CheckParam(double param, string paramName) => param > 0 ? param : throw new ArgumentOutOfRangeException(paramName, "Triangle side should not be zero or negative");
        }
        public bool IsRight()
        {
            var q = new[] { SideA, SideB, SideC }.Order().Select(s => s * s);
            return q.Take(2).Aggregate((s1, s2) => s1 + s2) == q.Last();
        }

        /// <summary>
        /// Calculates area of the triangle
        /// </summary>
        /// <returns>Area of the triangle</returns>
        public double CalculateArea()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;
            var radicand = semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC);
            return Math.Sqrt(radicand);
        }
    }
}
