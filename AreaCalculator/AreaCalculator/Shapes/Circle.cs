namespace AreaCalculator
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double[] dimensions)
        {
            _radius = dimensions[0];
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
