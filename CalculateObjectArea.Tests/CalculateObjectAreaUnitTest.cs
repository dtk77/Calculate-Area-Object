using System;
using Xunit;

namespace CalculateObjectArea.Tests
{
    public class CalculateObjectAreaUnitTest
    {
        [Fact]
        public void CalculateTheAreaOfCircle_ArgumentsAreCorrect()
        {
            //Arrange
            var radius = 5;

            //Act
            var result = CalculateObject.CalculateObjectArea(radius);

            //Assert
            Assert.Equal(78.54, result);
        }

        [Fact]
        public void CalculateAreaOfTriangle_ArgumentsAreCorrect()
        {
            //Arrange
            var a = 2;
            var b = 2;
            var c = 3;

            //Act
            var result = CalculateObject.CalculateObjectArea(a, b, c);

            //Assert
            Assert.Equal(1.984313483298443, result);
        }

        
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void
        CheckingArgumentsTriangle_throw_ExceptionMessage_if_any_arg_negative(
                                                             double a, double b, double c)
        {
            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                        HelperForCalculate.CheckingArguments(a, b, c));

            //Assert
            Assert.Equal("Arguments can be positive.", exception.Message);
        }

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        public void CheckingArgumentsTriangle_throw_ExceptionMessage_if_any_arg_zero(
                                                            double a, double b, double c)
        {
            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                        HelperForCalculate.CheckingArguments(a, b, c));

            //Assert
            Assert.Equal("Arguments can be positive.", exception.Message);
        }

        [Fact]
        public void
            CheckingArgumentsTriangle_throw_ExceptionMessage_if_BadSidesForTriangle()
        {
            //Arrange
            var a = 4;
            var b = 3;
            var c = 7;

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                        HelperForCalculate.CheckingArguments(a, b, c));

            //Assert
            Assert.Equal("Triangle does not exist. Fix sides.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void
            CheckingArgumentsOfCircle_throw_ExceptionMessage_if_arg_NOT_positive(double radius)
        {
            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() =>
                        HelperForCalculate.CheckingArguments(radius));

            //Assert
            Assert.Equal("Arguments can be positive.",
                         exception.Message);
        }
    }


    public class HalperForCalculate
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void isPositive_return_false_if_argument_not_positive(double a)
        {
            bool result = HelperForCalculate.isPositive(a);
            Assert.False(result);
        }

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void
            CheckingArgumentsTriangle_throw_exception_if_arg_NOT_positive(
                                                             double a, double b, double c)
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
                        HelperForCalculate.CheckingArguments(a, b, c));
        }

        // Check is triangle with right angle
        [Fact]
        public void CheckIsTriangleWithRightAngle_return_true_if_is_triangle_WithRightAngle()
        {
            //Arrange
            var a = 6;
            var b = 8;
            var c = 10;

            //Act
            var result = HelperForCalculate.CheckIsTriangleWithRightAngle(a, b, c);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckIsTriangleWithRightAngle_return_false_if_is_triangle_not_WithRightAngle()
        {
            //Arrange
            var a = 6;
            var b = 7;
            var c = 10;

            //Act
            var result = HelperForCalculate.CheckIsTriangleWithRightAngle(a, b, c);

            //Assert
            Assert.False(result);
        }

    }
}
