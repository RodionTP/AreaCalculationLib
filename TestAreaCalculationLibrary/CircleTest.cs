using System;
using AreaCalculationLibrary;
using Xunit;

namespace TestAreaCalculationLibrary
{
    public class CircleTest
    {
        [Fact]
        public void CircleArea()
        {
            var circle = new Circle(1);
            double exResult = Math.PI;
            var result = circle.GetSquare();
            Assert.Equal(exResult, result);


            var circle2 = new Circle(5);
            exResult = Math.PI * 25;
            result = circle2.GetSquare();
            Assert.Equal(exResult, result);
        }

        [Fact]
        public void CircleInput()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
