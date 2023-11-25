namespace AreaCalculator
{
    public static class Factory
    {
        public static IShape CreateShape(string shapeName, double[] dimensions)
        {
            ValidateInput(shapeName, dimensions);

            IShape shape;
            switch (shapeName.ToLower())
            {
                case "круг":
                    CheckDimensionCount(dimensions.Length, 1);
                    shape = new Circle(dimensions);
                    break;
                case "треугольник":
                    CheckDimensionCount(dimensions.Length, 3);
                    shape = new Triangle(dimensions);
                    break;
                default:
                    throw new ArgumentException("Данная фигура еще не доступна.");
            }

            return shape;
        }

        private static void ValidateInput(string shapeName, double[] dimensions)
        {
            if (string.IsNullOrEmpty(shapeName))
                throw new ArgumentException("Название фигуры не может быть пустым.");

            foreach (double dimension in dimensions)
            {
                if (dimension <= 0)
                    throw new ArgumentException("Длины всех размеров фигуры должны быть положительными.");
            }
        }

        private static void CheckDimensionCount(int value, int expectedDimensionCount)
        {
            if (value != expectedDimensionCount)
                throw new ArgumentException($"Данное количество размеров не соответствует этой фигуре.");
        }
    }
}