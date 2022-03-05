using Xunit;
using ShapeCalculator.ClassLibrary;

namespace ShapeCalculator.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void IsZeroOrGreaterTest_ReturnTrue()
        {
            InputValidation inputValidation = new InputValidation();
            double value = 5.294;
            Assert.True(inputValidation.IsZeroOrGreater(value));
        }

        [Fact]
        public void IsZeroOrGreaterTest_ReturnFalse()
        {
            InputValidation inputValidation = new InputValidation();
            double value = -0.5432;
            Assert.False(inputValidation.IsZeroOrGreater(value));
        }

        [Fact]
        public void IsRangeValidTest_ReturnTrue()
        {  
            InputValidation inputValidation = new InputValidation();
            Pool pool = new Pool();
            int value = 1;
            Assert.True(inputValidation.IsRangeValid(value, 0, pool.ShapesPool2D.Count));
        }

        [Fact]
        public void IsRangeValidTest_ReturnFalse()
        {  
            InputValidation inputValidation = new InputValidation();
            Pool pool = new Pool();
            int value = pool.ShapesPool2D.Count + 1;
            Assert.False(inputValidation.IsRangeValid(value, 0, pool.ShapesPool2D.Count));
        }

        [Theory]
        [InlineData("5")]
        [InlineData("-5")]
        [InlineData("123456")]
        public void IsValidInputAsInteger_ReturnTrue(string value)
        {
            InputValidation inputValidation = new InputValidation();
            Assert.True(inputValidation.ValidateAttributeInputAsInteger(value));
        }

        [Theory]
        [InlineData("22.75")]
        [InlineData("This is a string")]
        [InlineData("-999999999999999")]
        public void IsValidInputAsInteger_ReturnFalse(string value)
        {
            InputValidation inputValidation = new InputValidation();
            Assert.False(inputValidation.ValidateAttributeInputAsInteger(value));
        }
    } 
}