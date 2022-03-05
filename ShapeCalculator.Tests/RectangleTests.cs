using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(22.5, 15.3, 344.25)]
        [InlineData(18, 7.9, 142.2)]
        [InlineData(0.4, 58.2, 23.28)]
        public void RectangleArea_CorrectlyCalculated(double length, double width, double expectedValue)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ShapeInputAttributes["length"] = length;
            rectangle.ShapeInputAttributes["width"] = width;
            Assert.Equal(expectedValue, Math.Round(rectangle.CalculateArea(rectangle.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 5, 20)]
        [InlineData(22.5, 15.3, 75.6)]
        [InlineData(18, 7.9, 51.8)]
        [InlineData(0.4, 58.2, 117.2)]
        public void RectanglePerimeter_CorrectlyCalculated(double length, double width, double expectedValue)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ShapeInputAttributes["length"] = length;
            rectangle.ShapeInputAttributes["width"] = width;
            Assert.Equal(expectedValue, Math.Round(rectangle.CalculatePerimeter(rectangle.ShapeInputAttributes), 2));
        }
    } 
}