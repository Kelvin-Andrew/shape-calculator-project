using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class RightAngleTriangleTests
    {
        [Theory]
        [InlineData(5, 5, 12.5)]
        [InlineData(22.5, 15.3, 172.12)]
        [InlineData(18, 7.9, 71.1)]
        [InlineData(0.4, 58.2, 11.64)]
        public void RightAngleTriangleArea_CorrectlyCalculated(double legHeight, double legBase, double expectedValue)
        {
            RightAngleTriangle rightAngleTriangle = new RightAngleTriangle();
            rightAngleTriangle.ShapeInputAttributes["leg height"] = legHeight;
            rightAngleTriangle.ShapeInputAttributes["leg base"] = legBase;
            Assert.Equal(expectedValue, Math.Round(rightAngleTriangle.CalculateArea(rightAngleTriangle.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 5, 17.07)]
        [InlineData(22.5, 15.3, 65.01)]
        [InlineData(18, 7.9, 45.56)]
        [InlineData(0.4, 58.2, 116.8)]
        public void RightAngleTrianglePerimeter_CorrectlyCalculated(double legHeight, double legBase, double expectedValue)
        {
            RightAngleTriangle rightAngleTriangle = new RightAngleTriangle();
            rightAngleTriangle.ShapeInputAttributes["leg height"] = legHeight;
            rightAngleTriangle.ShapeInputAttributes["leg base"] = legBase;
            Assert.Equal(expectedValue, Math.Round(rightAngleTriangle.CalculatePerimeter(rightAngleTriangle.ShapeInputAttributes), 2));
        }
    } 
}