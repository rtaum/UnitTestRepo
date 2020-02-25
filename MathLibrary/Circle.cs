namespace MathLibrary
{
    public class Circle
    {
        private readonly ConfigProvider _provider;

        public Circle(ConfigProvider provider)
        {
            _provider = provider;
        }

        public double Area(double radius)
        {
            return _provider.Pi * radius * radius;
        }
    }
}
