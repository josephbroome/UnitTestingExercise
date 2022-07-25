using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-2,1,1,0)]
        [InlineData(0,0,0,0)]
        [InlineData(15,20,-15,20)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var unittest = new Calculator();

            //Act
            int actual = unittest.Add(num1, num2, num3);  

            //Assert
              Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(-1,-1,0)]
        [InlineData(1,2,-1)]
        [InlineData(-1,-2,1)]
        [InlineData(145667,56678,88989)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var unittest=new Calculator();
            //Act
            int actual=unittest.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1,0,0)]
        [InlineData(0,1,0)]
        [InlineData(2,2,4)]
        [InlineData(-1,-1,1)]
        [InlineData(1,-1,-1)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            var unittest= new Calculator();
            //Arrange
            int actual = unittest.Multiply(num1, num2);
            //Act

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,1,0)]
        [InlineData(1,0,0)]
        [InlineData(1,-2,0)]
        [InlineData(2,-1,-2)]
        [InlineData(-2,-1,2)]
        [InlineData(6,3,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var unittest = new Calculator();
            //Act
            int actual= unittest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
