using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5, 78.54)]
        [InlineData(17, 907.92)]
        [InlineData(22.5, 1590.43)]
        public void CircleArea_CorrectlyCalculated(double radius, double expectedValue)
        {
            CircleAdapter circleAdapter = new CircleAdapter(new Circle());
            circleAdapter.ShapeInputAttributes["radius"] = radius;
            Assert.Equal(expectedValue, Math.Round(circleAdapter.CalculateArea(circleAdapter.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 31.42)]
        [InlineData(17, 106.81)]
        [InlineData(22.5, 141.37)]
        public void CircleCircumference_CorrectlyCalculated(double radius, double expectedValue)
        {
            CircleAdapter circleAdapter = new CircleAdapter(new Circle());
            circleAdapter.ShapeInputAttributes["radius"] = radius;
            Assert.Equal(expectedValue, Math.Round(circleAdapter.CalculatePerimeter(circleAdapter.ShapeInputAttributes), 2));
        }
    } 
}