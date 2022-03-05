using System;
using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class SphereTests
    {
        [Theory]
        [InlineData(5, 314.16)]
        [InlineData(17, 3631.68)]
        [InlineData(22.5, 6361.73)]
        public void SphereSurfaceArea_CorrectlyCalculated(double radius, double expectedValue)
        {
            Sphere sphere = new Sphere();
            sphere.ShapeInputAttributes["radius"] = radius;
            Assert.Equal(expectedValue, Math.Round(sphere.CalculateSurfaceArea(sphere.ShapeInputAttributes), 2));
        }

        [Theory]
        [InlineData(5, 523.6)]
        [InlineData(17, 20579.53)]
        [InlineData(22.5, 47712.94)]   
        public void SphereVolume_CorrectlyCalculated(double radius, double expectedValue)
        {
            Sphere sphere = new Sphere();
            sphere.ShapeInputAttributes["radius"] = radius;
            Assert.Equal(expectedValue, Math.Round(sphere.CalculateVolume(sphere.ShapeInputAttributes), 2));
        }
    } 
}