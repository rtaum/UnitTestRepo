using MathLibrary;
using Xunit;

namespace MathLibraryTest
{
    public class CircleTest
    {
        [Fact]
        public void ShouldCalculateArea()
        {
            var circle = new Circle();
            var area = circle.Area(5);
            Assert.Equal(78.5, area, 1);
        }
    }
}
