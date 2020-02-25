using MathLibrary;
using NSubstitute;
using System;
using Xunit;

namespace MathLibraryTest
{
    public class CircleTest
    {
        [Fact]
        public void ShouldCalculateArea()
        {
            var provider = Substitute.For<IConfigProvider>();
            provider.Pi.Returns(Math.PI);

            var circle = new Circle(provider);
            var area = circle.Area(5);
            Assert.Equal(78.5, area, 1);
        }
    }
}
