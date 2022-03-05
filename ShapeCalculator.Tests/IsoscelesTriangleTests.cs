using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class IsoscelesTriangleTests
    {
        [Theory]
        [InlineData(5, 5, 12.5)]
        [InlineData(22.5, 15.3, 172.12)]
        [InlineData(18, 7.9, 71.1)]
        [InlineData(0.4, 58.2, 11.64)]
        public void IsoscelesTriangleArea_CorrectlyCalculated(double legHeight, double legBase, double expectedValue)
        {
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle();
            isoscelesTriangle.ShapeInputAttributes["height"] = legHeight;
            isoscelesTriangle.ShapeInputAttributes["base"] = legBase;
            Assert.Equal(expectedValue, Math.Round(isoscelesTriangle.CalculateArea(isoscelesTriangle.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 5, 15)]
        [InlineData(22.5, 15.3, 60.3)]
        [InlineData(18, 7.9, 43.9)]
        [InlineData(58.2, 0.9, 117.3)]
        public void IsoscelesTrianglePerimeter_CorrectlyCalculated(double side, double legBase, double expectedValue)
        {
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle();
            isoscelesTriangle.ShapeInputAttributes["side"] = side;
            isoscelesTriangle.ShapeInputAttributes["base"] = legBase;
            Assert.Equal(expectedValue, Math.Round(isoscelesTriangle.CalculatePerimeter(isoscelesTriangle.ShapeInputAttributes), 2));
        }
    } 
}