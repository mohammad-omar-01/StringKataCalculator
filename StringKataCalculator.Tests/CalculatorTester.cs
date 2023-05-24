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
            Calculator calculator = new Calculator();

            int actual= calculator.Add(_data);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}