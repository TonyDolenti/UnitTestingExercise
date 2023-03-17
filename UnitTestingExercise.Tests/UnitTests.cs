using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = calculator.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 7, 1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator1 = new Calculator();
            //Act
            var actual = calculator1.SubtractTest(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, 50)]//Add test data <-------
        public void MultiplyTest(int number1, int number2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator2 = new Calculator();
            //Act
            var actual = calculator2.MultiplyTest(number1, number2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 10, 2)]//Add test data <-------
        public void DivideTest(int n1, int n2, int expected)
        {
            //Arrange
            var calculator3 = new Calculator();
            //Act
            var actual = calculator3.DivideTest(n1, n2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
