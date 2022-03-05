using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class SquareTests
    {
        [Theory]
        [InlineData(5, 25)]
        [InlineData(17, 289)]
        [InlineData(22.5, 506.25)]
        public void SquareArea_CorrectlyCalculated(double sideLength, double expectedValue)
        {
            Square square = new Square();
            square.ShapeInputAttributes["side length"] = sideLength;
            Assert.Equal(expectedValue, Math.Round(square.CalculateArea(square.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 20)]
        [InlineData(17, 68)]
        [InlineData(22.55, 90.2)]
        public void SquarePerimeter_CorrectlyCalculated(double sideLength, double expectedValue)
        {
            Square square = new Square();
            square.ShapeInputAttributes["side length"] = sideLength;
            Assert.Equal(expectedValue, Math.Round(square.CalculatePerimeter(square.ShapeInputAttributes), 2));
        }
    } 
}