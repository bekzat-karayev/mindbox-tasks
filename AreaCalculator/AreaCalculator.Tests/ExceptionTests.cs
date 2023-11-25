namespace AreaCalculator.Tests
{
    public class ExceptionTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CreateShape_EmptyShapeName_ThrowArgumentException()
        {
            string shapeName = "";
            double[] dimensions = new double[]{ 1, 2};

            Assert.Throws(Is.TypeOf<ArgumentException>()
                .And.Message.EqualTo("Название фигуры не может быть пустым."), 
              () => Factory.CreateShape(shapeName, dimensions));
        }
        
        [Test]
        public void CreateShape_InvalidShapeName_ThrowArgumentException()
        {
            string shapeName = "линия";
            double[] dimensions = new double[]{ 1, 2};

            Assert.Throws(Is.TypeOf<ArgumentException>()
                .And.Message.EqualTo("Данная фигура еще не доступна."), 
              () => Factory.CreateShape(shapeName, dimensions));
        }
        
        [Test]
        public void CreateShape_InvalidDimensionCount_ThrowArgumentException()
        {
            string shapeName = "треугольник";
            double[] dimensions = new double[]{ 1, 2};

            Assert.Throws(Is.TypeOf<ArgumentException>()
                .And.Message.EqualTo("Данное количество размеров не соответствует этой фигуре."), 
              () => Factory.CreateShape(shapeName, dimensions));
        }
        
        [Test]
        public void CreateShape_NegativeDimension_ThrowArgumentException()
        {
            string shapeName = "треугольник";
            double[] dimensions = new double[]{ 1, -2, 3};

            Assert.Throws(Is.TypeOf<ArgumentException>()
                .And.Message.EqualTo("Длины всех размеров фигуры должны быть положительными."), 
              () => Factory.CreateShape(shapeName, dimensions));
        }
    }
}

