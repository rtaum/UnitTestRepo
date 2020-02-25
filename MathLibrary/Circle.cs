namespace MathLibrary
{
    public class Circle
    {
        private readonly IConfigProvider _provider;

        public Circle(IConfigProvider provider)
        {
            _provider = provider;
        }

        public double Area(double radius)
        {
            return _provider.Pi * radius * radius;
        }
    }
}
