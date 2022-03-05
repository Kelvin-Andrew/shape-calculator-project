using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class CuboidTests
    {
        [Theory]
        [InlineData(5, 5, 5, 150)]
        [InlineData(5.75, 6.23, 8.45, 274.11)]
        [InlineData(22.5, 303.5, 12, 21481.5)]
        [InlineData(15, 93.241, 12.111, 5419.04)]
        [InlineData(22.5, 63, 99.1043, 19781.84)]
        public void CuboidSurfaceArea_CorrectlyCalculated(double length, double width, double height, double expectedValue)
        {
            Cuboid cuboid = new Cuboid();
            cuboid.ShapeInputAttributes["length"] = length;
            cuboid.ShapeInputAttributes["width"] = width;
            cuboid.ShapeInputAttributes["height"] = height;
            Assert.Equal(expectedValue, Math.Round(cuboid.CalculateSurfaceArea(cuboid.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 5, 5, 125)]
        [InlineData(5.75, 6.23, 8.45, 302.7)]
        [InlineData(22.5, 303.5, 12, 81945)]
        [InlineData(15, 93.241, 12.111, 16938.63)]
        [InlineData(22.5, 63, 31.1043, 44090.35)]
        public void CuboidVolume_CorrectlyCalculated(double length, double width, double height, double expectedValue)
        {
            Cuboid cuboid = new Cuboid();
            cuboid.ShapeInputAttributes["length"] = length;
            cuboid.ShapeInputAttributes["width"] = width;
            cuboid.ShapeInputAttributes["height"] = height;
            Assert.Equal(expectedValue, Math.Round(cuboid.CalculateVolume(cuboid.ShapeInputAttributes), 2));
        }
    } 
}