namespace AreaCalculator.Tests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void GetArea_ValidRadius_ReturnCorrectCircleArea()
        {
            string shapeName = "круг";
            double[] dimensions = new double[]{ 2.5};
            var circle = Factory.CreateShape(shapeName, dimensions);
            double expected = Math.PI * Math.Pow(dimensions[0], 2);

            double result = circle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }        
        
        [Test]
        public void GetArea_ValidDimensions_ReturnCorrectTriangleArea()
        {
            string shapeName = "треугольник";
            double[] dimensions = new double[]{ 13, 14, 15};
            var triangle = Factory.CreateShape(shapeName, dimensions);
            double expected = 84;

            double result = triangle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }        
        
        [Test]
        public void IsRight_ValidDimensions_ReturnTrue()
        {
            string shapeName = "треугольник";
            double[] dimensions = new double[]{ 12, 13, 5};
            Triangle triangle = (Triangle)Factory.CreateShape(shapeName, dimensions);

            bool result = triangle.IsRight();

            Assert.IsTrue(result);
        }        
    }
}

