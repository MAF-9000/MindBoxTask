using FigureLibrary;
using System;
using System.IO;
using Xunit;

namespace FigureUnitTests
{
    public class FigureTests
    {
        [Theory]
        [InlineData(5d, 25d*Math.PI)]
        [InlineData(10d, 100d*Math.PI)]
        public void CalculateCircleArea(double radius, double trueArea)
        {
            var circle = new Circle(radius);
            var result = circle.СalculateArea();
            Assert.Equal(result,trueArea);
        }

        [Theory]
        [InlineData(3d,4d,5d, 6d)]
        [InlineData(5d,5d,6d, 12d)]
        [InlineData(5d,5d,8d, 12d)]
        public void CalculateTriangleArea(double a,double b,double c, double trueArea)
        {
            var triangle = new Triangle(a,b,c);
            var result = triangle.СalculateArea();
            Assert.Equal(result, trueArea);
        }

        [Theory]
        [InlineData(3d, 4d, 5d)]
        [InlineData(5d, 12d, 13d)]
        public void Triangle_IsRectangular(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.IsRectangular);
        }

        [Theory]
        [InlineData(3d, 3d, 5d)]
        [InlineData(5d, 11d, 13d)]
        public void Triangle_NotRectangular(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.False(triangle.IsRectangular);
        }

        [Fact]
        public void CreateTriangle_Successful()
        {
            Assert.NotNull(new Triangle(2, 3, 4));
        }

        [Fact]
        public void CreateTriangle_Throw()
        {
            Assert.Throws<InvalidDataException>(() => { new Triangle(1, 1, 4); });
        }

        [Fact]
        public void CreateCircle_Successful()
        {
            Assert.NotNull(new Circle(5));
        }

        [Fact]
        public void CreateCircle_Throw()
        {
            Assert.Throws<InvalidDataException>(() => { new Circle(-1); });
        }
    }
}
