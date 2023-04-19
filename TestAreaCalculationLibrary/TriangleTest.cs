using System;
using AreaCalculationLibrary;
using Xunit;

namespace TestAreaCalculationLibrary
{
    public class TriangleTest
    {
        [Fact]
        void TriangleInput()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 2, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(2, 5, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(2, 2, 5));

            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 0));

            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
        }

        [Fact]
        void TriangleArea()
        {
            var triangle = new Triangle(5, 12, 13);
            double exResult = 30.0;
            var result = triangle.GetSquare();
            Assert.Equal(exResult, result);

            var triangle2 = new Triangle(6, 8, 10);
            exResult = 24.0;
            result = triangle2.GetSquare();
            Assert.Equal(exResult, result);

            var triangle3 = new Triangle(5, 6, 7);
            exResult = 14.696938456699069;
            result = triangle3.GetSquare();
            Assert.Equal(exResult, result);
        }

        [Fact]
        void TriangleRight()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight());
            Assert.True(new Triangle(5, 12, 13).IsRight());
            Assert.True(new Triangle(6, 8, 10).IsRight());
            Assert.False(new Triangle(6, 7, 9).IsRight());
        }
    }
}
