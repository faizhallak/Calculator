using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void ShouldAddTwoNumbers()
        {
            //Arrange
            double expected = 10;
            double x = 4;
            double y = 6;

            //Act
            double actual = Calculator.Add(x, y);

            // Assertion
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldSubtractTwoNumbers()
        {
            //Arrange
            double expected = 10;
            double x = 20;
            double y = 10;

            //Act
            double actual = Calculator.Sub(x, y);

            // Assertion
            Assert.Equal(expected, actual);
        }
  
        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            //Arrange
            double expected = 10;
            double x = 2;
            double y = 5;

            //Act
            double actual = Calculator.Multi(x, y);

            // Assertion
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ShouldDivideTwoNumbers_ErrorIfDivideByZero()
        {
            //Arrange
            string expected = "You cannot divide by Zero";
            double x = 6;
            double y = 0;

            //Act
            string actual = Calculator.Div(x, y);

            // Assertion
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void OverloadAddArray()
        {
            //Arrange
            double expected = 151.66;
            double[] doubleArray = { 10.11, 20.22, 30.33, 40.44, 50.56 };
            

            //Act
            double actual = Calculator.Add(doubleArray);

            // Assertion
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void OverSubArray()
        {
            //Arrange
            double expected = -151.5;
            double[] doubleArray = { 10.10, 20.20, 30.30, 40.40, 50.50 };

            //Act
            double actual = Calculator.Sub(doubleArray);

            // Assertion
            Assert.Equal(expected, actual);
        }

    }
    
}
