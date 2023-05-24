using StringKataCalculator.logic;
using Xunit;
namespace StringKataCalculator.Tests
{
    public class CalculatorTester
    {
        Calculator calculator = new Calculator();
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]


        public void ShouldReturnZeroOfNullString(string _data,int expexted)
        {
            
            //Act
           

            int actual= calculator.Add(_data);

            //Assert
            Assert.Equal(expexted, actual);

        }
    }
}