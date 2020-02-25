using MathLibrary;
using Xunit;

namespace MathLibraryTest
{
    public class CircleTest
    {
        [Fact]
        public void ShouldCalculateArea()
        {
            var provider = new ConfigProvider();
            var circle = new Circle(provider);
            var area = circle.Area(5);
            Assert.Equal(78.5, area, 1);
        }
    }
}
