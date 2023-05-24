using StringKataCalculator.logic;
using Xunit;
namespace StringKataCalculator.Tests
{
    public class CalculatorTester
    {
        [Fact]
        public void ShouldReturnSumOfNumbersAsString()
        {
            //Arrange
            string _data = "";
            int  expected = 0;
            //Act
            int actual=Calculator.Add(_data);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}