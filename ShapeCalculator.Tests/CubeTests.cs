using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class CubeTests
    {
        [Theory]
        [InlineData(5, 150)]
        [InlineData(17, 1734)]
        [InlineData(22.5, 3037.5)]
        public void CubeSurfaceArea_CorrectlyCalculated(double sideLength, double expectedValue)
        {
            Cube cube = new Cube();
            cube.ShapeInputAttributes["side length"] = sideLength;
            Assert.Equal(expectedValue, Math.Round(cube.CalculateSurfaceArea(cube.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 125)]
        [InlineData(17, 4913)]
        [InlineData(22.5, 11390.62)]
        public void CubeVolume_CorrectlyCalculated(double sideLength, double expectedValue)
        {
            Cube cube = new Cube();
            cube.ShapeInputAttributes["side length"] = sideLength;
            Assert.Equal(expectedValue, Math.Round(cube.CalculateVolume(cube.ShapeInputAttributes), 2));
        }
    } 
}