namespace AreaCalculator
{
    public class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double[] dimensions)
        {
            Array.Sort(dimensions);
            a = dimensions[0];
            b = dimensions[1];
            c = dimensions[2];
        }

        public double GetArea()
        {
            double semiperimeter = (a + b + c) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        }

        public bool IsRight()
        {
            return Math.Pow(c, 2) - Math.Pow(b, 2) - Math.Pow(c, 2) == 0;
        }
    }
}