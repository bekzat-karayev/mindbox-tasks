using AreaCalculator;

namespace AreaCalculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var shape = Factory.CreateShape("circle", new double[]{ 1 });
            shape.GetArea();

            Triangle shape2 = (Triangle)Factory.CreateShape("Triangle", new double[]{ 1, 3, 43 });
            shape2.IsRight();

            Assert.Pass();
        }
    }
}

